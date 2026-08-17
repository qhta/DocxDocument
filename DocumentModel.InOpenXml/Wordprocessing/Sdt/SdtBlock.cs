namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the presence of a structured document tag around one or more block-level structures (SdtBlocks, tables, etc.).
/// This class provides properties for SDT configuration and end character formatting, enabling advanced management and customization of structured document tags for block-level content.
/// </summary>
[OpenXmlType(typeof(DXW.SdtBlock))]
[DataContract]
[XmlRoot("SdtBlock", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess]
[SpecificClass]
public partial class SdtBlock : ModelElement<DXW.SdtBlock>, IHexIdentObject, IStoryContent, ITableCellContent, ISdtBlockContent, ICustomXmlBlockContent, ICommentContent
{
  /// <summary>
  /// Initializes a new instance of the SdtBlock class.
  /// </summary>
  /// <remarks>This constructor creates a new SdtBlock element using the default settings. Use this constructor
  /// when you want to create a new SdtBlock in a document without copying from an existing one.</remarks>
  public SdtBlock(): base() { }


  /// <summary>
  /// Initializes a new instance of the SdtBlock class with the specified parent object.
  /// </summary>
  /// <param name = "parent">The parent object that will contain this SdtBlock instance. This parameter establishes the hierarchical relationship
  /// within the object model and cannot be null.</param>
  /// <param name = "openXmlElement">The OpenXmlCompositeElement that provides the XML data for the SdtBlock instance. Cannot be null.</param>
  public SdtBlock(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement) : base(parent, openXmlElement) { }

  /// <summary>
  /// Initializes a new instance of the SdtBlock class using the specified OpenXmlCompositeElement.  
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the underlying XML data for the SdtBlock.</param>
  public SdtBlock(DX.OpenXmlCompositeElement openXmlElement) : base(openXmlElement) { }
  private DXW.SdtBlock? _openXmlBlock => GetUpdatableElement() as DXW.SdtBlock;

  /// <summary>
  /// Gets the hexadecimal identifier of the structured document tag, which is used to uniquely identify the SDT within the document.
  /// </summary>
  public HexInt? HexId => SdtProperties?.SdtId;

  /// <summary>
  /// Specifies the set of properties applied to this structured document tag.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SdtBlock.SdtProperties))]
  public SdtProperties? SdtProperties 
  { 
    get => _SdtProperties ??= GetProperty<SdtProperties>(_openXmlBlock!.SdtProperties);
    set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties));
  }
  private SdtProperties? _SdtProperties;

  /// <summary>
  /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SdtBlock.SdtEndCharProperties))]
  public SdtEndCharProperties? SdtEndCharProperties
  {
    get => _SdtEndCharProperties ??= GetProperty<SdtEndCharProperties>(_openXmlBlock!.SdtEndCharProperties);
    set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties));
  }
  private SdtEndCharProperties? _SdtEndCharProperties;
}