namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the Accent function. 
///   If AccentChar is omitted, the default accent character is U+0302 (COMBINING CIRCUMFLEX ACCENT). 
/// </summary>
public partial class AccentProperties : ModelElement<DXM.AccentProperties>
{
    /// <summary>
    ///   Specifies visible accent character.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.AccentProperties.AccentChar))]
    /// <summary>
    ///   Specifies visible accent character.
    /// </summary>
    [OpenXmlElement(typeof(DXM.AccentProperties))]
    public string? AccentChar { get => _AccentChar; set => UpdateField(ref _AccentChar, value, nameof(AccentChar)); }

    private string? _AccentChar;
    /// <summary>
    ///   Specifies formatting of accent character.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.AccentProperties.ControlProperties))]
    /// <summary>
    ///   Specifies formatting of accent character.
    /// </summary>
    [OpenXmlElement(typeof(DXM.AccentProperties))]
    public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

    private ControlProperties? _ControlProperties;
}