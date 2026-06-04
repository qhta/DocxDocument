namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement for an OLE object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoleplacement?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOLEPlacement")]
public enum OLEPlacement
{
  /// <summary>
  /// In line with text.
  /// </summary>
  [WordInteropEnumValue("wdInLine")]
  InLine = 0,
  /// <summary>
  /// Float over text.
  /// </summary>
  [WordInteropEnumValue("wdFloatOverText")]
  FloatOverText = 1
}
