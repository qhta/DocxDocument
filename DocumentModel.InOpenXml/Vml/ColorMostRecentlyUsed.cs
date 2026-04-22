namespace DocumentModel.Vml;
/// <summary>
///   Most Recently Used Colors.
/// </summary>
[OpenXmlType(typeof(DXVO.ColorMostRecentlyUsed))]
[XmlRoot("ColorMostRecentlyUsed", Namespace = "DocumentModel.Vml")]
public partial class ColorMostRecentlyUsed : ModelElement<DXVO.ColorMostRecentlyUsed>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMostRecentlyUsed.Extension))]
 public ExtensionHandlingBehavior? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }
 private ExtensionHandlingBehavior? _Extension;

 /// <summary>
 ///   Recent colors
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.ColorMostRecentlyUsed.Colors))]
 public string? Colors { get => _Colors; set => UpdateField(ref _Colors, value, nameof(Colors)); }
 private string? _Colors;
}