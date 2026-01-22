namespace DocumentModel.Vml;
/// <summary>
///   Most Recently Used Colors.
/// </summary>
public partial class ColorMostRecentlyUsed : ModelElement<DXVO.ColorMostRecentlyUsed>
{
    /// <summary>
    ///   VML Extension Handling Behavior
    /// </summary>
    public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

    private ExtensionHandlingBehaviorKind? _Extension;
    /// <summary>
    ///   Recent colors
    /// </summary>
    public string? Colors { get; set; }
}