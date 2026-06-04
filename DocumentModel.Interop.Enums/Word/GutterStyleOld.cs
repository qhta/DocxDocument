namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the gutter style should conform to left-to-right text flow or right-to-left text flow.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgutterstyleold?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdGutterStyleOld")]
public enum GutterStyleOld
{
  /// <summary>
  /// Bidirectional gutter should be used to conform to right-to-left text flow.
  /// </summary>
  [WordInteropEnumValue("wdGutterStyleBidi")]
  Bidi = 2,
  /// <summary>
  /// Latin gutter should be used to conform to left-to-right text flow.
  /// </summary>
  [WordInteropEnumValue("wdGutterStyleLatin")]
  Latin = -10
}
