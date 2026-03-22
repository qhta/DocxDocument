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
  /// Updates the abstract numberings in the specified OpenXml element with abstract numberings defined in the AbstractNumberings collection.  
  /// </summary>
  /// <remarks>This method passes the specified element to the AbstractNumberings collection for updating.</remarks>
  /// <param name="element">The OpenXml element to update. Must be of type <see cref="DXW.Numberings"/>.</param>
  /// <exception cref="ArgumentException">Thrown if <paramref name="element"/> is not of type <see cref="DXW.Numberings"/>.</exception>
  public void UpdateAbstractNumberings(DX.OpenXmlElement element)
  {
    AbstractNumberings.UpdateNumberings(element);
  }
  /// <summary>
  /// Loads abstract numberings from the specified OpenXmlElement into the AbstractNumberings collection, replacing any existing abstract numbering.
  /// </summary>
  /// <remarks>This method passes the specified element to the AbstractNumberings collection for loading.</remarks>
  /// <param name="element">The OpenXmlElement containing the abstract numberings to load. Must be of type DXW.Numberings.</param>
  /// <exception cref="ArgumentException">Thrown if the provided element is not of type DXW.Numberings.</exception>
  public void LoadAbstractNumberings(DX.OpenXmlElement element)
  {
    AbstractNumberings.LoadNumberings(element);
  }
  /// <summary>
  /// Collection of numbering instances definitions
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.NumberingInstance))]
  [OpenXmlUpdateData(nameof(UpdateNumberingInstances))]
  [OpenXmlLoadData(nameof(LoadNumberingInstances))]
  public NumberingInstances NumberingInstances
  {
    get
    {
      if (_NumberingInstances == null)
        _NumberingInstances = new NumberingInstances(this);
      return _NumberingInstances;
    }
    set => UpdateField(ref _NumberingInstances, value, nameof(NumberingInstances));
  }
  private NumberingInstances? _NumberingInstances;

  /// <summary>
  /// Updates the numbering instances in the specified OpenXml element with numbering instances defined in the NumberingInstances collection.  
  /// </summary>
  /// <remarks>This method passes the specified element to the NumberingInstances collection for updating.</remarks>
  /// <param name="element">The OpenXml element to update. Must be of type <see cref="DXW.Numbering"/>.</param>
  /// <exception cref="ArgumentException">Thrown if <paramref name="element"/> is not of type <see cref="DXW.Numbering"/>.</exception>
  public void UpdateNumberingInstances(DX.OpenXmlElement element)
  {
    NumberingInstances.UpdateNumberings(element);
  }
  /// <summary>
  /// Loads numbering instances from the specified OpenXmlElement into the NumberingInstances collection, replacing any existing NumberingInstances.
  /// </summary>
  /// <remarks>This method passes the specified element to the NumberingInstances collection for loading.</remarks>
  /// <param name="element">The OpenXmlElement containing the numbering instances to load. Must be of type DXW.NumberingInstances.</param>
  /// <exception cref="ArgumentException">Thrown if the provided element is not of type DXW.NumberingInstances.</exception>
  public void LoadNumberingInstances(DX.OpenXmlElement element)
  {
    NumberingInstances.LoadNumberings(element);
  }
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