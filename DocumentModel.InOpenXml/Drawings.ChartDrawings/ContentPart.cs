namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a content part embedded within a chart drawing that references external content through relationships.
/// </summary>
/// <remarks>
///   This class defines a content part element that can embed external
///   content within a chart through relationship-based references. Content parts enable charts to incorporate rich
///   content such as images, diagrams, or other visual elements that are stored separately and referenced via
///   relationship identifiers. The content part includes properties for the relationship reference, black-and-white
///   mode rendering, non-visual properties (both content-specific and application-specific), 2D transformation for
///   positioning and sizing, and extensibility support. This architecture supports efficient content reuse across
///   multiple charts and documents while maintaining the chart's structure. Content parts are particularly useful
///   for including complex graphics, logos, or supplementary visual elements that enhance the chart's presentation
///   without embedding the actual content data directly within the chart definition.
/// </remarks>
[OpenXmlType(typeof(DXO10DCD.ContentPart))]
[XmlRoot("ContentPart", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ContentPart : ModelElement<DXO10DCD.ContentPart> //: OfficeArtExtendableElement
{
  /// <summary>
  /// Specifies the relationship id.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.ContentPart.RelationshipId))]
  public string? RelationshipId { get => _RelationshipId; set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId)); }

  private string? _RelationshipId;
  /// <summary>
  /// Specifies the black white mode.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.ContentPart.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

  private BlackWhiteMode? _BlackWhiteMode;
  /// <summary>
  /// Specifies the non visual content part properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.ContentPart.NonVisualContentPartProperties))]
  public NonVisualContentPartProperties? NonVisualContentPartProperties { get => _NonVisualContentPartProperties; set => UpdateField(ref _NonVisualContentPartProperties, value, nameof(NonVisualContentPartProperties)); }

  private NonVisualContentPartProperties? _NonVisualContentPartProperties;
  /// <summary>
  /// Specifies the application non visual drawing properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.ContentPart.ApplicationNonVisualDrawingProperties))]
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get => _ApplicationNonVisualDrawingProperties; set => UpdateField(ref _ApplicationNonVisualDrawingProperties, value, nameof(ApplicationNonVisualDrawingProperties)); }

  private ApplicationNonVisualDrawingProperties? _ApplicationNonVisualDrawingProperties;
  /// <summary>
  /// Specifies the transform2d.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DCD.ContentPart.Transform2D))]
  public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

  private Transform2D? _Transform2D;
}