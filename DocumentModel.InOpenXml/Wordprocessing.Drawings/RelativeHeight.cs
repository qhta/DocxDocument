namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the relative height settings for a drawing element in a Wordprocessing document.
/// This class provides configuration for vertical size adjustment, including the reference point and percentage height relative to another element.
/// </summary>
public partial class RelativeHeight : ModelElement<DXO10WD.RelativeHeight>
{
    /// <summary>
    /// The reference point used to determine the relative vertical sizing, such as margin, page, or paragraph.
    /// </summary>
    public SizeRelativeVerticallyKind? RelativeFrom { get => _RelativeFrom; set => UpdateField(ref _RelativeFrom, value, nameof(RelativeFrom)); }

    private SizeRelativeVerticallyKind? _RelativeFrom;
    /// <summary>
    /// The percentage value specifying the height of the drawing element relative to the reference point.
    /// </summary>
    public string? PercentageHeight { get => _PercentageHeight; set => UpdateField(ref _PercentageHeight, value, nameof(PercentageHeight)); }

    private string? _PercentageHeight;
}