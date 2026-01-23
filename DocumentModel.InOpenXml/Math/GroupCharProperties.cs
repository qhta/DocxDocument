namespace DocumentModel.Math;
/// <summary>
///   Group-Character Properties.
/// </summary>
public partial class GroupCharProperties : ModelElement<DXM.GroupCharProperties>
{
    /// <summary>
    ///   Group Character (Grouping Character).
    /// </summary>
    [OpenXmlProperty(nameof(DXM.GroupCharProperties.AccentChar))]
    public string? AccentChar { get => _AccentChar; set => UpdateField(ref _AccentChar, value, nameof(AccentChar)); }

    private string? _AccentChar;
    /// <summary>
    ///   Position (Group Character).
    /// </summary>
    [OpenXmlProperty(nameof(DXM.GroupCharProperties.Position))]
    public VerticalJustificationKind? Position { get => _Position; set => UpdateField(ref _Position, value, nameof(Position)); }

    private VerticalJustificationKind? _Position;
    /// <summary>
    ///   Vertical Justification.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.GroupCharProperties.VerticalJustification))]
    public VerticalJustificationKind? VerticalJustification { get => _VerticalJustification; set => UpdateField(ref _VerticalJustification, value, nameof(VerticalJustification)); }

    private VerticalJustificationKind? _VerticalJustification;
    /// <summary>
    ///   Specifies formatting of group-char object argument.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.GroupCharProperties.ControlProperties))]
    public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

    private ControlProperties? _ControlProperties;
}