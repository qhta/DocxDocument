namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the relative width settings for a drawing element in a Wordprocessing document.
/// This interface provides configuration for horizontal size adjustment, including the reference object and percentage width relative to another element.
/// </summary>
public partial class RelativeWidth : ModelElement
{
    /// <summary>
    /// The reference object used to determine the relative horizontal sizing, such as margin, page, or paragraph.
    /// </summary>
    public SizeRelativeHorizontallyKind? ObjectId { get => _ObjectId; set => UpdateField(ref _ObjectId, value, nameof(ObjectId)); }

    private SizeRelativeHorizontallyKind? _ObjectId;
    /// <summary>
    /// The percentage value specifying the width of the drawing element relative to the reference object.
    /// </summary>
    public string? PercentageWidth { get; set; }
}