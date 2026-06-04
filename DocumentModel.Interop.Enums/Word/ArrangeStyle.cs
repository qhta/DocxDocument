namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the window arrangement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdarrangestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdArrangeStyle")]
public enum ArrangeStyle
{
  /// <summary>
  /// Windows are tiled into a single window.
  /// </summary>
  [WordInteropEnumValue("wdTiled")]
  Tiled = 0,
  /// <summary>
  /// Windows are displayed as icons in a single window.
  /// </summary>
  [WordInteropEnumValue("wdIcons")]
  Icons = 1
}
