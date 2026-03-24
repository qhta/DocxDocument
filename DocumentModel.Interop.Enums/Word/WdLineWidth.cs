namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the width of an object's border.
/// </summary>
public enum WdLineWidth
{
  /// <summary>
  /// 0.25 point.
  /// </summary>
  Pt025 = unchecked((int)2),
  /// <summary>
  /// 0.50 point.
  /// </summary>
  Pt050 = unchecked((int)4),
  /// <summary>
  /// 0.75 point.
  /// </summary>
  Pt075 = unchecked((int)6),
  /// <summary>
  /// 1.00 point. default.
  /// </summary>
  Pt100 = unchecked((int)8),
  /// <summary>
  /// 1.50 points.
  /// </summary>
  Pt150 = unchecked((int)12),
  /// <summary>
  /// 2.25 points.
  /// </summary>
  Pt225 = unchecked((int)18),
  /// <summary>
  /// 3.00 points.
  /// </summary>
  Pt300 = unchecked((int)24),
  /// <summary>
  /// 4.50 points.
  /// </summary>
  Pt450 = unchecked((int)36),
  /// <summary>
  /// 6.00 points.
  /// </summary>
  Pt600 = unchecked((int)48)
}
