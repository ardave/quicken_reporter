open System
open System.IO
open System.Linq
open System.Xml.Serialization
open xml_types

type TransactionInfo =
    { DateTime    : DateTime 
      Amount      : decimal
      AccountName : string }

type Transaction =
| Contribution    of TransactionInfo
| DividendPayment of TransactionInfo

let getDate (d:decimal) =
    let s = d.ToString()
    let yr = int (s.Substring(0,4))
    let mo = int (s.Substring(3, 2))
    let da = int (s.Substring(5, 2))
    DateTime(yr, mo, da)

[<EntryPoint>]
let main argv =
    if argv.Length <> 1 then
        printfn "Only 1 arg allowed, the path to the quicken files folder."
        1
    else
        let transactions = ResizeArray()
        let files = Directory.GetFiles argv.[0] 
        let serializer = new XmlSerializer(typedefof<OFX>)
        for file in files do
            printfn "Opening file %s" file
            let fileContent = File.ReadAllText(file)
            let idx = fileContent.IndexOf('<')
            let xmlOnly = fileContent.Substring(idx)
            use reader = new StringReader(xmlOnly)
            let ofx = serializer.Deserialize(reader) :?> OFX

            let bankTransactions = ofx.INVSTMTMSGSRSV1.INVSTMTTRNRS.INVSTMTRS.INVTRANLIST.Items.OfType<BankTransaction>().ToList()
            let dividends = 
                ofx.INVSTMTMSGSRSV1.INVSTMTTRNRS.INVSTMTRS.INVTRANLIST.Items.OfType<Income>().Where(fun i -> i.INCOMETYPE = "DIV")
                |> Seq.map(fun orig -> 
                    )

            for item in ofx.INVSTMTMSGSRSV1.INVSTMTTRNRS.INVSTMTRS.INVTRANLIST.Items.OfType<BankTransaction>().ToList() do
                printfn "%s" <| item.GetType().Name
            ()
        printfn "yay"
        0
