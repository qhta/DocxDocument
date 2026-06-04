namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the window arrangement.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdarrangestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdArrangeStyle))]
public enum ArrangeStyle
{
  /// <summary>
  /// Windows are tiled into a single window.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdArrangeStyle.wdTiled))]
  Tiled = 0,
  /// <summary>
  /// Windows are displayed as icons in a single window.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdArrangeStyle.wdIcons))]
  Icons = 1
}
