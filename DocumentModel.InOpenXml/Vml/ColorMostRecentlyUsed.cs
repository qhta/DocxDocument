namespace DocumentModel.Vml;
/// <summary>
///   Most Recently Used Colors.
/// </summary>
public partial class ColorMostRecentlyUsed : ModelElement<DXVO.ColorMostRecentlyUsed>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ColorMostRecentlyUsed.Extension))]
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ColorMostRecentlyUsed))]
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Recent colors
    /// </summary>
    [OpenXmlProperty(nameof(DXVO.ColorMostRecentlyUsed.Colors))]
    /// <summary>
    ///   Recent colors
    /// </summary>
    [OpenXmlElement(typeof(DXVO.ColorMostRecentlyUsed))]
    public string? Colors { get => _Colors; set => UpdateField(ref _Colors, value, nameof(Colors)); }

    private string? _Colors;
}