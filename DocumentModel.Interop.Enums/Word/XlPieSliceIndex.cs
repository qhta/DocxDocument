namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which position on the slice to return the coordinate of.
/// </summary>
public enum XlPieSliceIndex
{
  /// <summary>
  /// The outermost counterclockwise point of the circumference of a slice.
  /// </summary>
  xlOuterCounterClockwisePoint = unchecked((int)1),
  /// <summary>
  /// The outer center point of the circumference of a slice.
  /// </summary>
  xlOuterCenterPoint = unchecked((int)2),
  /// <summary>
  /// The outermost clockwise point of the circumference of a slice.
  /// </summary>
  xlOuterClockwisePoint = unchecked((int)3),
  /// <summary>
  /// The midpoint of the most clockwise radius of a slice.
  /// </summary>
  xlMidClockwiseRadiusPoint = unchecked((int)4),
  /// <summary>
  /// The center point of a pie slice.
  /// </summary>
  xlCenterPoint = unchecked((int)5),
  /// <summary>
  /// The midpoint of the most counterclockwise radius of a slice.
  /// </summary>
  xlMidCounterClockwiseRadiusPoint = unchecked((int)6),
  /// <summary>
  /// The innermost point of the most clockwise radius of a doughnut slice.
  /// </summary>
  xlInnerClockwisePoint = unchecked((int)7),
  /// <summary>
  /// The innermost center point of a doughnut slice.
  /// </summary>
  xlInnerCenterPoint = unchecked((int)8),
  /// <summary>
  /// The innermost point of the most counterclockwise radius of a doughnut slice.
  /// </summary>
  xlInnerCounterClockwisePoint = unchecked((int)9)
}
