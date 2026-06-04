namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which position on the slice to return the coordinate of.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpiesliceindex?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlPieSliceIndex))]
public enum PieSliceIndex
{
  /// <summary>
  /// The outermost counterclockwise point of the circumference of a slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlOuterCounterClockwisePoint))]
  OuterCounterClockwisePoint = 1,
  /// <summary>
  /// The outer center point of the circumference of a slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlOuterCenterPoint))]
  OuterCenterPoint = 2,
  /// <summary>
  /// The outermost clockwise point of the circumference of a slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlOuterClockwisePoint))]
  OuterClockwisePoint = 3,
  /// <summary>
  /// The midpoint of the most clockwise radius of a slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlMidClockwiseRadiusPoint))]
  MidClockwiseRadiusPoint = 4,
  /// <summary>
  /// The center point of a pie slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlCenterPoint))]
  CenterPoint = 5,
  /// <summary>
  /// The midpoint of the most counterclockwise radius of a slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlMidCounterClockwiseRadiusPoint))]
  MidCounterClockwiseRadiusPoint = 6,
  /// <summary>
  /// The innermost point of the most clockwise radius of a doughnut slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlInnerClockwisePoint))]
  InnerClockwisePoint = 7,
  /// <summary>
  /// The innermost center point of a doughnut slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlInnerCenterPoint))]
  InnerCenterPoint = 8,
  /// <summary>
  /// The innermost point of the most counterclockwise radius of a doughnut slice.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPieSliceIndex.xlInnerCounterClockwisePoint))]
  InnerCounterClockwisePoint = 9
}
