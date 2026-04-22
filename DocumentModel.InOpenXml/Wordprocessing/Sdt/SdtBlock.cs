namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.).
/// This class provides properties for SDT configuration and end character formatting, enabling advanced management and customization of structured document tags for block-level content.
/// </summary>
[OpenXmlType(typeof(DXW.SdtBlock))]
[XmlRoot("SdtBlock", Namespace = "DocumentModel.Wordprocessing")]
[SpecificClass]
public partial class SdtBlock : ModelElement<DXW.SdtBlock>, IStoryContent, ITableCellContent, ISdtBlockContent, ICustomXmlBlockContent, ICommentContent
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public SdtBlock() : base() { }

  /// <summary>
  /// Constructor that initializes the element within an owner collection.
  /// </summary>
  /// <param name="collection">The collection to which this element belongs.</param>
  public SdtBlock(object collection) : base(collection) { }

  /// <summary>
  /// Specifies the set of properties applied to this structured document tag.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SdtBlock.SdtProperties))]
  public SdtProperties? SdtProperties { get => _SdtProperties; set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties)); }
  private SdtProperties? _SdtProperties;

  /// <summary>
  /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SdtBlock.SdtEndCharProperties))]
  public SdtEndCharProperties? SdtEndCharProperties { get => _SdtEndCharProperties; set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties)); }
  private SdtEndCharProperties? _SdtEndCharProperties;
}