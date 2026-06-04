namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text orientation.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlOrientation))]
public enum XlOrientation
{
  /// <summary>
  /// Text runs upward.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlOrientation.xlUpward))]
  Upward = -4171,
  /// <summary>
  /// Text runs downward.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlOrientation.xlDownward))]
  Downward = -4170,
  /// <summary>
  /// Text runs downward and is centered in the cell.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlOrientation.xlVertical))]
  Vertical = -4166,
  /// <summary>
  /// Text runs horizontally.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlOrientation.xlHorizontal))]
  Horizontal = -4128
}
