namespace DocumentModel.Vml;

/// <summary>
///   Diagram Relationship.
/// </summary>
[OpenXmlType(typeof(DXVO.Relation))]
[DataContract]
[XmlRoot("Relation", Namespace = "DocumentModel.Vml")]
public partial class Relation: ModelElement<DXVO.Relation>
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Relation.Extension))]
  public ExtensionHandlingBehavior? Extension
  {
    get => _Extension ??= GetProperty<ExtensionHandlingBehavior?>(GetUpdatableElement()?.Extension);
    set => UpdateField(ref _Extension, value, nameof(Extension));
  }

  private ExtensionHandlingBehavior? _Extension;

  /// <summary>
  ///   Diagram Relationship Source Shape
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Relation.SourceId))]
  public string? SourceId
  {
    get => _SourceId ??= GetProperty<string?>(GetUpdatableElement()?.SourceId);
    set => UpdateField(ref _SourceId, value, nameof(SourceId));
  }

  private string? _SourceId;

  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Relation.DestinationId))]
  public string? DestinationId
  {
    get => _DestinationId ??= GetProperty<string?>(GetUpdatableElement()?.DestinationId);
    set => UpdateField(ref _DestinationId, value, nameof(DestinationId));
  }

  private string? _DestinationId;

  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Relation.CenterShapeId))]
  public string? CenterShapeId
  {
    get => _CenterShapeId ??= GetProperty<string?>(GetUpdatableElement()?.CenterShapeId);
    set => UpdateField(ref _CenterShapeId, value, nameof(CenterShapeId));
  }

  private string? _CenterShapeId;
}