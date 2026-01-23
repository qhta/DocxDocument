namespace DocumentModel.Drawings;
/// <summary>
///   Represents a tab stop in text, including its position and alignment.
/// </summary>
public partial class TabStop : ModelElement<DXD.TabStop>
{
    /// <summary>
    ///   Position of the tab stop.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TabStop.Position))]
    /// <summary>
    ///   Position of the tab stop.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TabStop))]
    public Int32? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private Int32? _Position;
    /// <summary>
    ///   Alignment type for the tab stop.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TabStop.Alignment))]
    /// <summary>
    ///   Alignment type for the tab stop.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TabStop))]
    public TextTabAlignmentKind? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

    private TextTabAlignmentKind? _Alignment;
}