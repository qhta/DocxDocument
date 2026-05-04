namespace DocumentModel.Wordprocessing;
/// <summary>
///   Numbering Definitions.
/// </summary>
[OpenXmlType(typeof(DXW.Numbering))]
[XmlRoot("Numbering", Namespace = "DocumentModel.Wordprocessing")]
public sealed partial class Numbering : ModelElement<DXW.Numbering>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Numbering()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">The document to attach to.</param>
  public Numbering(Document document) : this()
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's Numberings part.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var numbering = wordprocessingDocument.GetNumbering();
    SetUpdatableElement(numbering);
    LoadData(numbering);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's Numberings part.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var numbering = wordprocessingDocument.GetNumbering();
    SetUpdatableElement(numbering);
    UpdateData(numbering);
  }

  /// <summary>
  /// Specifies to a consumer the progress in the last attempt made by the application to remove unused abstract numbering
  /// definitions from a given document. If a legacy document is opened by a consumer, it can choose to remove abstract
  /// numbering definition which are 'orphaned' (have no associated numbering definition instances). This element is used
  /// by those consumers to indicate their progress (if not complete) in reviewing existing abstract numbering definitions.
  /// </summary>
  [OpenXmlElement(typeof(DXW.NumberingIdMacAtCleanup))]
  public int? LastRevAbstractNumbering { get => _lastRevAbstractNumbering; set => UpdateField(ref _lastRevAbstractNumbering, value, nameof(LastRevAbstractNumbering)); }
  private int? _lastRevAbstractNumbering;

  /// <summary>
  /// Collection of abstract numbering definitions
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.AbstractNum))]
  public AbstractNumberings AbstractNumberings
  {
    get => _AbstractNumberings ??= new AbstractNumberings(this);
    set => AbstractNumberings.CopyFrom(value);
  }
  private AbstractNumberings? _AbstractNumberings;

  /// <summary>
  /// Collection of numbering instances definitions
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.NumberingInstance))]
  public NumberingInstances NumberingInstances
  {
    get => _NumberingInstances ??= new NumberingInstances(this);
    set => NumberingInstances.CopyFrom(value);
  }
  private NumberingInstances? _NumberingInstances;

  //  /// <summary>
  //  /// Collection of numbering picture bullets
  //  /// </summary>
  //  public NumberingPictureBullets? NumberingPictureBullets
  //  {
  //    get => _NumberingPictureBullets;
  //    set => UpdateField(ref _NumberingPictureBullets, value, nameof(NumberingPictureBullets));
  //  }
  //  private NumberingPictureBullets? _NumberingPictureBullets;
}