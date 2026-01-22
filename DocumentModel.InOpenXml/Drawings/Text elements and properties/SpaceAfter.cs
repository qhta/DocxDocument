namespace DocumentModel.Drawings;
/// <summary>
///   Represents the space after a paragraph, allowing specification as a percentage or in points.
/// </summary>
public partial class SpaceAfter : ModelElement
{
    /// <summary>
    ///   Space after the paragraph specified as a percentage.
    /// </summary>
    public Int32? SpacingPercent { get => _SpacingPercent; set => UpdateField(ref _SpacingPercent, value, nameof(SpacingPercent)); }

    private Int32? _SpacingPercent;
    /// <summary>
    ///   Space after the paragraph specified in points.
    /// </summary>
    public Int32? SpacingPoints { get; set; }
}