namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies a set of properties which shall dictate the appearance and behavior of a set of numbered paragraphs. 
///   These properties are collectively called an abstract numbering definition, 
///   and are the basis for all numbering information in a WordprocessingML document.
///   Although an abstract numbering definition contains a complete set of numbering, it shall not be directly referenced by content 
///   (hence the use of abstract). Instead, these properties shall be inherited by a numbering definition instance using the num element, 
///   which can then itself be referenced by content.
/// </summary>
[OpenXmlType(typeof(DXW.AbstractNum))]
[XmlRoot("AbstractNumbering", Namespace = "DocumentModel.Wordprocessing")]
public partial class AbstractNumbering : ModelElement<DXW.AbstractNum>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public AbstractNumbering() : base() { }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="collection">The collection of abstract numberings to which this instance belongs.</param>
  /// <param name="openXmlElement">The OpenXml element to wrap and synchronize with. It can be null.</param>
  public AbstractNumbering(AbstractNumberings collection, DXW.AbstractNum? openXmlElement = null) : base(collection, openXmlElement) { }

  /// <summary>
  ///   Specifies a unique number which shall be used as the identifier for this abstract numbering definition. 
  ///   This unique number shall be referenced by any numbering definition instance 
  ///   in order to inherit the properties specified by this abstract numbering definition.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.AbstractNumberId))]
  [Required]
  public Int32? AbstractNumId { get => _abstractNumId; set => UpdateField(ref _abstractNumId, value, nameof(AbstractNumId)); }
  private Int32? _abstractNumId;

  /// <summary>
  ///   Associates a unique hexadecimal ID to the abstract numbering definition. 
  ///   This number shall be identical for two abstract numbering definitions that are based from the same initial numbering definition 
  ///   - if a document is repurposed and the underlying numbering definition is changed, it shall maintain its original nsid.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.Nsid))]
  public HexInt? NsId { get => _NsId; set => UpdateField(ref _NsId, value, nameof(NsId)); }
  private HexInt? _NsId;

  /// <summary>
  ///   Specifies the name of a given abstract numbering definition. 
  ///   This name can be surfaced in order to provide a user-friendly alias for a given numbering definition, 
  ///   but shall not influence the behavior of the list - two identical definitions with different name elements shall behave identically.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.AbstractNumDefinitionName))]
  public string? Name { get => _name; set => UpdateField(ref _name, value, nameof(Name)); }
  private string? _name;

  /// <summary>
  ///   Specifies the type of numbering defined by a given abstract numbering type. 
  ///   This information shall only be used by a consumer to determine user interface behaviors for this numbering definition, 
  ///   and shall not be used to limit the behavior of the list 
  ///   (i.e. a list with multiple levels marked as singleLevel shall not be prevented from using levels 2 through 9).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.MultiLevelType))]
  public MultiLevel? MultiLevelType { get => _MultiLevelType; set => UpdateField(ref _MultiLevelType, value, nameof(MultiLevelType)); }
  private MultiLevel? _MultiLevelType;

  /// <summary>
  ///   Specifies a unique hexadecimal code which can be used to determine a location within application user interface 
  ///   in which this abstract numbering definition shall be displayed.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.TemplateCode))]
  public HexInt? TemplateCode { get => _TemplateCode; set => UpdateField(ref _TemplateCode, value, nameof(TemplateCode)); }
  private HexInt? _TemplateCode;

  /// <summary>
  ///    Specifies that the parent abstract numbering definition is the base numbering definition 
  ///    for the specified numbering style referenced in its val attribute.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.StyleLink))]
  public string? StyleLink { get => _StyleLink; set => UpdateField(ref _StyleLink, value, nameof(StyleLink)); }
  private string? _StyleLink;

  /// <summary>
  ///   Specifies an abstract numbering that does not contain the actual numbering properties for its numbering type, 
  ///   but rather serves as a reference to a numbering style stored in the document, 
  ///   which shall be applied when this abstract numbering definition is referenced, 
  ///   and itself points at the actual underlying abstract numbering definition to be used.  /// </summary>
  [OpenXmlProperty(nameof(DXW.AbstractNum.NumberingStyleLink))]
  public string? NumberingStyleLink { get => _NumberingStyleLink; set => UpdateField(ref _NumberingStyleLink, value, nameof(NumberingStyleLink)); }
  private string? _NumberingStyleLink;

  /// <summary>
  ///   Definitions of numbering levels.
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.Level))]
  [OpenXmlUpdateData(nameof(UpdateNumberingLevels))]
  [OpenXmlLoadData(nameof(LoadNumberingLevels))]
  public NumberingLevels Levels
  {
    get
    {
      if (_Levels == null)
        _Levels = new NumberingLevels(this);
      return _Levels;
    }

    set => UpdateField(ref _Levels, value, nameof(Levels));
  }
  private NumberingLevels? _Levels;

  /// <summary>
  /// Updates the numbering levels of the specified OpenXmlElement.
  /// </summary>
  /// <remarks>This method updates the numbering levels only if the Levels property is not null. Ensure that the
  /// Levels property is initialized before calling this method.</remarks>
  /// <param name = "element">The OpenXmlElement whose numbering levels are to be updated. This parameter must not be null.</param>
  public void UpdateNumberingLevels(DX.OpenXmlElement element)
  {
    Levels?.UpdateLevels(element);
  }

  /// <summary>
  /// Loads numbering levels from the specified OpenXmlElement into the current instance.
  /// </summary>
  /// <remarks>This method delegates the loading operation to the Levels property, if it is not null. Use this
  /// method to import numbering level information from an OpenXmlElement, such as when processing WordprocessingML
  /// documents.</remarks>
  /// <param name = "element">The OpenXmlElement that contains the numbering level definitions to load. Cannot be null.</param>
  public void LoadNumberingLevels(DX.OpenXmlElement element)
  {
    Levels?.LoadLevels(element);
  }
}