namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
[XmlRoot("Rsids")]
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
  /// Copies data from the specified Rsids instance to this instance.
  /// </summary>
  /// <param name = "properties">Rsids instance containing the model property value.</param>
  public void CopyFrom(Rsids properties)
  {
    var modelType = properties.GetType();
    foreach (var item in properties)
    {
      this.Add(item);
    }

    var updatableElement = GetUpdatableElement();
    if (updatableElement != null)
      UpdateData(updatableElement);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's DocumentSettings.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var documentSettings = wordprocessingDocument.GetDocumentSettings();
    var rsids = documentSettings.Elements<DXW.Rsids>().FirstOrDefault();
    if (rsids == null)
    {
      rsids = new DXW.Rsids();
      documentSettings.AddChildUsingSchemaOrder(rsids);
    }
    SetUpdatableElement(rsids);
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
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var documentSettings = wordprocessingDocument.GetDocumentSettings();
    var rsids = documentSettings.Elements<DXW.Rsids>().FirstOrDefault();
    if (rsids == null)
    {
      rsids = new DXW.Rsids();
      documentSettings.AddChildUsingSchemaOrder(rsids);
    }
    SetUpdatableElement(rsids);
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