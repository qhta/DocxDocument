namespace DocumentModel.Wordprocessing;

/// <summary>
///   Numbering Definitions.
/// </summary>
[OpenXmlType(typeof(DXW.Numbering))]
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
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's FontTable.
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
  /// Attach this instance to the specified document. Data is stored to the document's FontTable.
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
  public int? LastRevAbstractNumbering
  {
    get => _lastRevAbstractNumbering;
    set => UpdateField(ref _lastRevAbstractNumbering, value, nameof(LastRevAbstractNumbering));
  }

  private int? _lastRevAbstractNumbering;

  /// <summary>
  /// Collection of abstract numbering definitions
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.AbstractNum))]
  [OpenXmlUpdateData(nameof(UpdateAbstractNumberings))]
  [OpenXmlLoadData(nameof(LoadAbstractNumberings))]
  public AbstractNumberings AbstractNumberings
  {
    get
    {
      if (_AbstractNumberings == null)
        _AbstractNumberings = new AbstractNumberings(this);
      return _AbstractNumberings;
    }
    set => UpdateField(ref _AbstractNumberings, value, nameof(AbstractNumberings));
  }

  private AbstractNumberings? _AbstractNumberings;

  /// <summary>
  /// Updates the abstractnumberings in the specified OpenXml element b with abstractnumberings defined in the DefinedAbstractNumberings collection.  
  /// </summary>
  /// <remarks>This method passes the specified element to the DefinedAbstractNumberings collection for updating.</remarks>
  /// <param name="element">The OpenXml element to update. Must be of type <see cref="DXW.AbstractNumberings"/>.</param>
  /// <exception cref="ArgumentException">Thrown if <paramref name="element"/> is not of type <see cref="DXW.AbstractNumberings"/>.</exception>
  public void UpdateAbstractNumberings(DX.OpenXmlElement element)
  {
    AbstractNumberings.UpdateNumberings(element);
  }

  /// <summary>
  /// Loads abstractnumberings from the specified OpenXmlElement into the DefinedAbstractNumberings collection, replacing any existing abstractnumberings.
  /// </summary>
  /// <remarks>This method passes the specified element to the DefinedAbstractNumberings collection for loading.</remarks>
  /// <param name="element">The OpenXmlElement containing the abstractnumberings to load. Must be of type DXW.AbstractNumberings.</param>
  /// <exception cref="ArgumentException">Thrown if the provided element is not of type DXW.AbstractNumberings.</exception>
  public void LoadAbstractNumberings(DX.OpenXmlElement element)
  {
    AbstractNumberings.LoadNumberings(element);
  }

  /// <summary>
  /// Collection of numbering instances definitions
  /// </summary>
  public NumberingInstances? NumberingInstances
  {
    get => _NumberingInstances;
    set => UpdateField(ref _NumberingInstances, value, nameof(NumberingInstances));
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