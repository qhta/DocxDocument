namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents line numbering settings for a section in a Wordprocessing document.
/// This class provides properties for line number increments, starting value, distance between text and line numbers, and restart settings, enabling advanced configuration of line numbering behavior and appearance.
/// </summary>
public partial class LineNumberType : ModelElement<DXW.LineNumberType>, ISectionPropertiesContent
{
    /// <summary>
    /// Line number increments to display, specifying the interval between displayed line numbers.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.LineNumberType.CountBy))]
    public Int16? CountBy { get => _CountBy; set => UpdateField(ref _CountBy, value, nameof(CountBy)); }

    private Int16? _CountBy;
    /// <summary>
    /// Line numbering starting value, specifying the initial line number for the section.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.LineNumberType.Start))]
    public Int16? Start { get => _Start; set => UpdateField(ref _Start, value, nameof(Start)); }

    private Int16? _Start;
    /// <summary>
    /// Distance between text and line numbering, specifying the spacing for line number placement.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.LineNumberType.Distance))]
    public string? Distance { get => _Distance; set => UpdateField(ref _Distance, value, nameof(Distance)); }

    private string? _Distance;
    /// <summary>
    /// Line numbering restart setting, specifying when line numbering should restart (e.g., each page or section).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.LineNumberType.Restart))]
    public LineNumberRestartKind? Restart { get => _Restart; set => UpdateField(ref _Restart, value, nameof(Restart)); }

    private LineNumberRestartKind? _Restart;
}