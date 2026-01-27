namespace DocumentModel.Drawings;
/// <summary>
///   Represents a compatibility extension element in DrawingML, providing additional metadata for shapes to support compatibility scenarios across Office versions or applications.
///   Includes a shape identifier and an associated URI for extension identification.
/// </summary>
[OpenXmlType(typeof(DXO10D.CompatExtension))]
public partial class CompatExtension : ModelElement<DXO10D.CompatExtension>, IExtension
{
  /// <summary>
  ///   Identifier for the shape associated with this compatibility extension, used to link the extension to a specific shape in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.CompatExtension.ShapeId))]
  public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }

  private string? _ShapeId;

  /// <summary>
  ///   URI string associated with the compatibility extension, identifying the extension type or schema for compatibility purposes.
  /// </summary>
  public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

  private string? _Uri;
}
