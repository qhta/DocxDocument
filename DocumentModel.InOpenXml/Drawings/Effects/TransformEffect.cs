namespace DocumentModel.Drawings;
/// <summary>
///   Represents a transform effect, allowing adjustment of scaling, skew, and shift for a drawing element.
/// </summary>
public partial class TransformEffect : ModelElement
{
    /// <summary>
    ///   Horizontal scaling ratio.
    /// </summary>
    public Int32? HorizontalRatio { get => _HorizontalRatio; set => UpdateField(ref _HorizontalRatio, value, nameof(HorizontalRatio)); }

    private Int32? _HorizontalRatio;
    /// <summary>
    ///   Vertical scaling ratio.
    /// </summary>
    public Int32? VerticalRatio { get; set; }
    /// <summary>
    ///   Horizontal skew value.
    /// </summary>
    public Int32? HorizontalSkew { get; set; }
    /// <summary>
    ///   Vertical skew value.
    /// </summary>
    public Int32? VerticalSkew { get; set; }
    /// <summary>
    ///   Horizontal shift value.
    /// </summary>
    public Int64? HorizontalShift { get; set; }
    /// <summary>
    ///   Vertical shift value.
    /// </summary>
    public Int64? VerticalShift { get; set; }
}