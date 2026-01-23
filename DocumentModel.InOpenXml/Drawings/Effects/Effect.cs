namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a visual effect that can be applied to drawing objects.
/// </summary>
public partial class Effect : ModelElement<DXD.Effect>
{
    /// <summary>
    ///   Reference identifier that links to a specific effect definition.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.Effect.Reference))]
    /// <summary>
    ///   Reference identifier that links to a specific effect definition.
    /// </summary>
    [OpenXmlElement(typeof(DXD.Effect))]
    public string? Reference { get => _Reference; set => UpdateField(ref _Reference, value, nameof(Reference)); }

    private string? _Reference;
}