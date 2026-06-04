namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlHAlign))]
public enum HAlign
{
  /// <summary>
  /// Align according to data type.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignGeneral))]
  General = 1,
  /// <summary>
  /// Fill.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignFill))]
  Fill = 5,
  /// <summary>
  /// Center across selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignCenterAcrossSelection))]
  CenterAcrossSelection = 7,
  /// <summary>
  /// Right.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignRight))]
  Right = -4152,
  /// <summary>
  /// Left.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignLeft))]
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignJustify))]
  Justify = -4130,
  /// <summary>
  /// Distribute.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignDistributed))]
  Distributed = -4117,
  /// <summary>
  /// Center.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlHAlign.xlHAlignCenter))]
  Center = -4108
}
