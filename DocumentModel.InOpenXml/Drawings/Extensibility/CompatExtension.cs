namespace DocumentModel.Drawings;
/// <summary>
/// Represents a compatibility extension, including a shape identifier.
/// </summary>
[OpenXmlType(typeof(DXO10D.CompatExtension))]
public partial class CompatExtension : ModelElement<DXO10D.CompatExtension>, IExtension
{
 /// <summary>
 /// Shape identifier.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.CompatExtension.ShapeId))]
 /// <summary>
 /// Shape identifier.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.CompatExtension))]
 public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }

 private string? _ShapeId;
 [OpenXmlElement(typeof(DXO10D.CompatExtension))]
 public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

 private string? _Uri;
}