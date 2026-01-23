namespace DocumentModel.Drawings;
/// <summary>
/// Color change effect for drawing elements.
/// </summary>
public partial class ColorChange : ModelElement<DXD.ColorChange>
{
    /// <summary>
    /// Consider alpha values.
    /// </summary>
    public bool? UseAlpha { get => _UseAlpha; set => UpdateField(ref _UseAlpha, value, nameof(UseAlpha)); }

    private bool? _UseAlpha;
    /// <summary>
    /// Change color from.
    /// </summary>
    public Color? ColorFrom { get; set; }
    /// <summary>
    /// Change color to.
    /// </summary>
    public Color? ColorTo { get; set; }
}