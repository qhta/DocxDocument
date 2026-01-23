namespace DocumentModel.Drawings;
/// <summary>
///   Indicates that text is not rendered in 3D scene.
/// </summary>
public partial class FlatText : ModelElement<DXD.FlatText>
{
    /// <summary>
    ///   Z coordinate for positioning in 3D space.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.FlatText.Z))]
    /// <summary>
    ///   Z coordinate for positioning in 3D space.
    /// </summary>
    [OpenXmlElement(typeof(DXD.FlatText))]
    public Int64? Z { get => _Z; set => UpdateField(ref _Z, value, nameof(Z)); }

    private Int64? _Z;
}