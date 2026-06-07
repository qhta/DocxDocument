namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlHAlign")]
public enum HAlign
{
  /// <summary>
  /// Align according to data type.
  /// </summary>
  [InteropEnumValue("xlHAlignGeneral")]
  General = 1,
  /// <summary>
  /// Fill.
  /// </summary>
  [InteropEnumValue("xlHAlignFill")]
  Fill = 5,
  /// <summary>
  /// Center across selection.
  /// </summary>
  [InteropEnumValue("xlHAlignCenterAcrossSelection")]
  CenterAcrossSelection = 7,
  /// <summary>
  /// Right.
  /// </summary>
  [InteropEnumValue("xlHAlignRight")]
  Right = -4152,
  /// <summary>
  /// Left.
  /// </summary>
  [InteropEnumValue("xlHAlignLeft")]
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  [InteropEnumValue("xlHAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Distribute.
  /// </summary>
  [InteropEnumValue("xlHAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Center.
  /// </summary>
  [InteropEnumValue("xlHAlignCenter")]
  Center = -4108
}

