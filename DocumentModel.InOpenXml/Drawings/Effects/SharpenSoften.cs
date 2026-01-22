namespace DocumentModel.Drawings;
/// <summary>
///   Represents a sharpen or soften effect, allowing adjustment of the amount for image enhancement.
/// </summary>
public partial class SharpenSoften : ModelElement
{
    /// <summary>
    ///   Amount of sharpening or softening applied.
    /// </summary>
    public Int32? Amount { get => _Amount; set => UpdateField(ref _Amount, value, nameof(Amount)); }

    private Int32? _Amount;
}