namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the width of an object's border.
/// </summary>
public enum WdLineWidth
{
  /// <summary>
  /// 0.25 point.
  /// </summary>
  wdLineWidth025pt = unchecked((int)2),
  /// <summary>
  /// 0.50 point.
  /// </summary>
  wdLineWidth050pt = unchecked((int)4),
  /// <summary>
  /// 0.75 point.
  /// </summary>
  wdLineWidth075pt = unchecked((int)6),
  /// <summary>
  /// 1.00 point. default.
  /// </summary>
  wdLineWidth100pt = unchecked((int)8),
  /// <summary>
  /// 1.50 points.
  /// </summary>
  wdLineWidth150pt = unchecked((int)12),
  /// <summary>
  /// 2.25 points.
  /// </summary>
  wdLineWidth225pt = unchecked((int)18),
  /// <summary>
  /// 3.00 points.
  /// </summary>
  wdLineWidth300pt = unchecked((int)24),
  /// <summary>
  /// 4.50 points.
  /// </summary>
  wdLineWidth450pt = unchecked((int)36),
  /// <summary>
  /// 6.00 points.
  /// </summary>
  wdLineWidth600pt = unchecked((int)48)
}
