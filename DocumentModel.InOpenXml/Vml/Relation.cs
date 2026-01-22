namespace DocumentModel.Vml;
/// <summary>
///   Diagram Relationship.
/// </summary>
public partial class Relation : ModelElement<DXVO.Relation>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Diagram Relationship Source Shape
    /// </summary>
    public string? SourceId { get; set; }
    /// <summary>
    ///   Diagram Relationship Destination Shape
    /// </summary>
    public string? DestinationId { get; set; }
    /// <summary>
    ///   Diagram Relationship Center Shape
    /// </summary>
    public string? CenterShapeId { get; set; }
}