namespace DocumentModel.Math;
/// <summary>
///   Specifies the properties of <see cref = "Delimiter"/>, including the enclosing and separating characters, 
///   and the properties that affect the shape of the delimiters.
/// </summary>
public partial class DelimiterProperties : ModelElement<DXM.DelimiterProperties>
{
    /// <summary>
    ///   Delimiter Beginning Character.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.DelimiterProperties.BeginChar))]
    /// <summary>
    ///   Delimiter Beginning Character.
    /// </summary>
    [OpenXmlElement(typeof(DXM.DelimiterProperties))]
    public string? BeginChar { get => _BeginChar; set => UpdateField(ref _BeginChar, value, nameof(BeginChar)); }

    private string? _BeginChar;
    /// <summary>
    ///   Delimiter Separator Character.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.DelimiterProperties.SeparatorChar))]
    /// <summary>
    ///   Delimiter Separator Character.
    /// </summary>
    [OpenXmlElement(typeof(DXM.DelimiterProperties))]
    public string? SeparatorChar { get => _SeparatorChar; set => UpdateField(ref _SeparatorChar, value, nameof(SeparatorChar)); }

    private string? _SeparatorChar;
    /// <summary>
    ///   Delimiter Ending Character.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.DelimiterProperties.EndChar))]
    /// <summary>
    ///   Delimiter Ending Character.
    /// </summary>
    [OpenXmlElement(typeof(DXM.DelimiterProperties))]
    public string? EndChar { get => _EndChar; set => UpdateField(ref _EndChar, value, nameof(EndChar)); }

    private string? _EndChar;
    /// <summary>
    ///   Allows separators to grow according to operator size.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.DelimiterProperties.GrowOperators))]
    /// <summary>
    ///   Allows separators to grow according to operator size.
    /// </summary>
    [OpenXmlElement(typeof(DXM.DelimiterProperties))]
    public bool? GrowOperators { get => _GrowOperators; set => UpdateField(ref _GrowOperators, value, nameof(GrowOperators)); }

    private bool? _GrowOperators;
    /// <summary>
    ///   Specifies if delimiter are vertically centered around the delimited expression,
    ///   or they are matched to the baseline of the expression.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.DelimiterProperties.Shape))]
    /// <summary>
    ///   Specifies if delimiter are vertically centered around the delimited expression,
    ///   or they are matched to the baseline of the expression.
    /// </summary>
    [OpenXmlElement(typeof(DXM.DelimiterProperties))]
    public ShapeDelimiterKind? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }

    private ShapeDelimiterKind? _Shape;
    /// <summary>
    ///   Specifies formatting of delimiter object argument.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.DelimiterProperties.ControlProperties))]
    /// <summary>
    ///   Specifies formatting of delimiter object argument.
    /// </summary>
    [OpenXmlElement(typeof(DXM.DelimiterProperties))]
    public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

    private ControlProperties? _ControlProperties;
}