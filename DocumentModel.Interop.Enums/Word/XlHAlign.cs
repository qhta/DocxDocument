namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlHAlign")]
public enum HAlign
{
  /// <summary>
  /// Align according to data type.
  /// </summary>
  [WordInteropEnumValue("xlHAlignGeneral")]
  General = 1,
  /// <summary>
  /// Fill.
  /// </summary>
  [WordInteropEnumValue("xlHAlignFill")]
  Fill = 5,
  /// <summary>
  /// Center across selection.
  /// </summary>
  [WordInteropEnumValue("xlHAlignCenterAcrossSelection")]
  CenterAcrossSelection = 7,
  /// <summary>
  /// Right.
  /// </summary>
  [WordInteropEnumValue("xlHAlignRight")]
  Right = -4152,
  /// <summary>
  /// Left.
  /// </summary>
  [WordInteropEnumValue("xlHAlignLeft")]
  Left = -4131,
  /// <summary>
  /// Justify.
  /// </summary>
  [WordInteropEnumValue("xlHAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Distribute.
  /// </summary>
  [WordInteropEnumValue("xlHAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Center.
  /// </summary>
  [WordInteropEnumValue("xlHAlignCenter")]
  Center = -4108
}
