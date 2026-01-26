namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
[XmlRoot("Rsids")]
/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(HexInt))]
public sealed partial class Rsids : ValueCollection<HexInt, DXW.Rsids, DXW.Rsid>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public Rsids()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "document">Wordprocessing document model</param>
 public Rsids(Wordprocessing.Document document)
 {
  if (document.WordprocessingDocument != null)
   AttachAndLoad(document.WordprocessingDocument);
 }

 /// <summary>
 /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's DocumentSettings.
 /// </summary>
 /// <param name = "wordprocessingDocument">Document to attach to.</param>
 public override void AttachAndLoad(DXPack.WordprocessingDocument wordprocessingDocument)
 {
  base.AttachAndLoad(wordprocessingDocument);
  var documentSettings = wordprocessingDocument.GetDocumentSettings();
  var rsids = documentSettings.Elements<DXW.Rsids>().FirstOrDefault();
  if (rsids == null)
  {
   return;
  }

  SetOpenXmlElement(rsids);
  LoadData(rsids);
  if (rsids.RsidRoot != null)
  {
   // ReSharper disable once SpecifyACultureInStringConversionExplicitly
   if (this.Count == 0 || this[0].ToString() != rsids.RsidRoot.Val?.Value)
   {
    this.Insert(0, new HexInt(rsids.RsidRoot.Val?.Value!));
   }
  }
 }

 /// <summary>
 /// Attach this instance to the specified document. Data is stored to the document's DocumentSettings.
 /// </summary>
 /// <param name = "wordprocessingDocument">Document to attach to.</param>
 public override void AttachAndUpdate(DXPack.WordprocessingDocument wordprocessingDocument)
 {
  base.AttachAndUpdate(wordprocessingDocument);
  var documentSettings = wordprocessingDocument.GetDocumentSettings();
  var rsids = documentSettings.Elements<DXW.Rsids>().FirstOrDefault();
  if (rsids == null)
  {
   rsids = new DXW.Rsids();
   documentSettings.Append(rsids);
  }

  SetOpenXmlElement(rsids);
  UpdateData(rsids);
  if (this.Count > 0)
  {
   // ReSharper disable once SpecifyACultureInStringConversionExplicitly
   rsids.RsidRoot = new DXW.RsidRoot
   {
    Val = new DX.HexBinaryValue(this[0].ToString())
   };
   if (rsids.Elements<DXW.Rsid>().Any())
   {
    var rsid = rsids.Elements<DXW.Rsid>().First();
    if (rsid.Val == rsids.RsidRoot.Val)
     rsid.Remove();
   }
  }
  else
   rsids.RsidRoot = null;
 }
}