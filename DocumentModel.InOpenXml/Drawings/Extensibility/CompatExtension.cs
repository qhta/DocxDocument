namespace DocumentModel.Drawings;
/// <summary>
/// Represents a compatibility extension, including a shape identifier.
/// </summary>
public partial class CompatExtension : ModelElement<DXO10D.CompatExtension>, IExtension
{
    /// <summary>
    /// Shape identifier.
    /// </summary>
    public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }

    private string? _ShapeId;
    public string? Uri { get => _Uri; set => UpdateField(ref _Uri, value, nameof(Uri)); }

    private string? _Uri;
}