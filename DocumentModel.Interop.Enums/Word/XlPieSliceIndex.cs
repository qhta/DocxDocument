namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which position on the slice to return the coordinate of.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpiesliceindex?view=office-pia` for Office interop details.
/// </remarks>
public enum XlPieSliceIndex
{
  /// <summary>
  /// The outermost counterclockwise point of the circumference of a slice.
  /// </summary>
  OuterCounterClockwisePoint = 1,
  /// <summary>
  /// The outer center point of the circumference of a slice.
  /// </summary>
  OuterCenterPoint = 2,
  /// <summary>
  /// The outermost clockwise point of the circumference of a slice.
  /// </summary>
  OuterClockwisePoint = 3,
  /// <summary>
  /// The midpoint of the most clockwise radius of a slice.
  /// </summary>
  MidClockwiseRadiusPoint = 4,
  /// <summary>
  /// The center point of a pie slice.
  /// </summary>
  CenterPoint = 5,
  /// <summary>
  /// The midpoint of the most counterclockwise radius of a slice.
  /// </summary>
  MidCounterClockwiseRadiusPoint = 6,
  /// <summary>
  /// The innermost point of the most clockwise radius of a doughnut slice.
  /// </summary>
  InnerClockwisePoint = 7,
  /// <summary>
  /// The innermost center point of a doughnut slice.
  /// </summary>
  InnerCenterPoint = 8,
  /// <summary>
  /// The innermost point of the most counterclockwise radius of a doughnut slice.
  /// </summary>
  InnerCounterClockwisePoint = 9
}
