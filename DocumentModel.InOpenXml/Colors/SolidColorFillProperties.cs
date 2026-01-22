namespace DocumentModel;
/// <summary>
///   Defines the SolidColorFillProperties Class.
/// </summary>
public partial class SolidColorFillProperties : ModelElement
{
    /// <summary>
    ///   RgbColorModelHex.
    /// </summary>
    public RgbColor? RgbColor { get => _RgbColor; set => UpdateField(ref _RgbColor, value, nameof(RgbColor)); }

    private RgbColor? _RgbColor;
    /// <summary>
    ///   SchemeColor.
    /// </summary>
    public SchemeColor? SchemeColor { get; set; }
}