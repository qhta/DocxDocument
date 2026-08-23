namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents a canvas element in a Wordprocessing document for grouping and organizing graphical content.
/// This class provides access to background formatting, whole formatting, shapes, pictures, groups, graphic frames, and extension data, enabling advanced layout and rendering of graphical objects within the document.
/// </summary>
[OpenXmlType(typeof(DXO10WDC.WordprocessingCanvas))]
[DataContract]
[XmlRoot("WordprocessingCanvas", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class WordprocessingCanvas : ModelElement<DXO10WDC.WordprocessingCanvas>
{
  /// <summary>
  /// Background formatting settings for the canvas, specifying fill, effects, and other background properties.
  /// </summary>
  public BackgroundFormatting? BackgroundFormatting { get => _BackgroundFormatting; set => UpdateField(ref _BackgroundFormatting, value, nameof(BackgroundFormatting)); }
  private BackgroundFormatting? _BackgroundFormatting;

  /// <summary>
  /// Whole formatting settings for the canvas, specifying outline and effects applied to the entire canvas.
  /// </summary>
  public WholeFormatting? WholeFormatting { get => _WholeFormatting; set => UpdateField(ref _WholeFormatting, value, nameof(WholeFormatting)); }
  private WholeFormatting? _WholeFormatting;

  /// <summary>
  /// A shape element contained within the canvas, representing an individual graphical object.
  /// </summary>
  public Shape? WordprocessingShape { get => _WordprocessingShape; set => UpdateField(ref _WordprocessingShape, value, nameof(WordprocessingShape)); }
  private Shape? _WordprocessingShape;

  /// <summary>
  /// A picture element contained within the canvas, representing an embedded image.
  /// </summary>
  public DocumentModel.Drawings.Pictures.Picture? Picture { get => _Picture; set => UpdateField(ref _Picture, value, nameof(Picture)); }
  private DocumentModel.Drawings.Pictures.Picture? _Picture;

  /// <summary>
  /// A group of drawing elements contained within the canvas, enabling hierarchical organization of graphical content.
  /// </summary>
  public WordprocessingGroup? WordprocessingGroup { get => _WordprocessingGroup; set => UpdateField(ref _WordprocessingGroup, value, nameof(WordprocessingGroup)); }
  private WordprocessingGroup? _WordprocessingGroup;

  /// <summary>
  /// A graphic frame type element contained within the canvas, used for advanced graphical content such as images, charts, or diagrams.
  /// </summary>
  public GraphicFrameType? GraphicFrameType { get => _GraphicFrameType; set => UpdateField(ref _GraphicFrameType, value, nameof(GraphicFrameType)); }
  private GraphicFrameType? _GraphicFrameType;

  /// <summary>
  /// List of OfficeArt extensions associated with the canvas, allowing for additional metadata or custom features.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get => _OfficeArtExtensionList; set => UpdateField(ref _OfficeArtExtensionList, value, nameof(OfficeArtExtensionList)); }
  private OfficeArtExtensionList? _OfficeArtExtensionList;
}