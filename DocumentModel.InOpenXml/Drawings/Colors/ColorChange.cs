namespace DocumentModel.Drawings;
/// <summary>
/// Color change effect for drawing elements.
/// </summary>
public partial class ColorChange : ModelElement<DXD.ColorChange>
{
    /// <summary>
    /// Consider alpha values.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorChange.UseAlpha))]
    public bool? UseAlpha { get => _UseAlpha; set => UpdateField(ref _UseAlpha, value, nameof(UseAlpha)); }

    private bool? _UseAlpha;
    /// <summary>
    /// Change color from.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorChange.ColorFrom))]
    public Color? ColorFrom { get => _ColorFrom; set => UpdateField(ref _ColorFrom, value, nameof(ColorFrom)); }

    private Color? _ColorFrom;
    /// <summary>
    /// Change color to.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ColorChange.ColorTo))]
    public Color? ColorTo { get => _ColorTo; set => UpdateField(ref _ColorTo, value, nameof(ColorTo)); }

    private Color? _ColorTo;
}