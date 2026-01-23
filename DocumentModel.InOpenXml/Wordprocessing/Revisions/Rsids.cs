namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
[XmlRoot("Rsids")]
public sealed partial class Rsids : ModelElementCollection<Rsid, DXW.Rsids, DXW.Rsid>
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

  public override void LoadData(object openXmlElement)
  {
    base.LoadData(openXmlElement);
  }

  public override void UpdateData(object openXmlElement)
  {
    base.UpdateData(openXmlElement);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's PackageProperties.
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
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
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
  }


  /// <summary>
  /// Original document revision save ID, identifying the root revision of the document.
  /// </summary>
  [OpenXmlProperty(nameof(Rsids.RsidRoot))]
  public Rsid? RsidRoot { get => _RsidRoot; set => UpdateField(ref _RsidRoot, value, nameof(RsidRoot)); }

  private Rsid? _RsidRoot;
}