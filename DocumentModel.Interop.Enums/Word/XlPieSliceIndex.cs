namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which position on the slice to return the coordinate of.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpiesliceindex?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlPieSliceIndex")]
public enum PieSliceIndex
{
  /// <summary>
  /// The outermost counterclockwise point of the circumference of a slice.
  /// </summary>
  [WordInteropEnumValue("xlOuterCounterClockwisePoint")]
  OuterCounterClockwisePoint = 1,
  /// <summary>
  /// The outer center point of the circumference of a slice.
  /// </summary>
  [WordInteropEnumValue("xlOuterCenterPoint")]
  OuterCenterPoint = 2,
  /// <summary>
  /// The outermost clockwise point of the circumference of a slice.
  /// </summary>
  [WordInteropEnumValue("xlOuterClockwisePoint")]
  OuterClockwisePoint = 3,
  /// <summary>
  /// The midpoint of the most clockwise radius of a slice.
  /// </summary>
  [WordInteropEnumValue("xlMidClockwiseRadiusPoint")]
  MidClockwiseRadiusPoint = 4,
  /// <summary>
  /// The center point of a pie slice.
  /// </summary>
  [WordInteropEnumValue("xlCenterPoint")]
  CenterPoint = 5,
  /// <summary>
  /// The midpoint of the most counterclockwise radius of a slice.
  /// </summary>
  [WordInteropEnumValue("xlMidCounterClockwiseRadiusPoint")]
  MidCounterClockwiseRadiusPoint = 6,
  /// <summary>
  /// The innermost point of the most clockwise radius of a doughnut slice.
  /// </summary>
  [WordInteropEnumValue("xlInnerClockwisePoint")]
  InnerClockwisePoint = 7,
  /// <summary>
  /// The innermost center point of a doughnut slice.
  /// </summary>
  [WordInteropEnumValue("xlInnerCenterPoint")]
  InnerCenterPoint = 8,
  /// <summary>
  /// The innermost point of the most counterclockwise radius of a doughnut slice.
  /// </summary>
  [WordInteropEnumValue("xlInnerCounterClockwisePoint")]
  InnerCounterClockwisePoint = 9
}
