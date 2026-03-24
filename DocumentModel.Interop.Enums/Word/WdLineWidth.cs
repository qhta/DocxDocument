namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the width of an object's border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinewidth?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLineWidth
{
  /// <summary>
  /// 0.25 point.
  /// </summary>
  Pt025 = 2,
  /// <summary>
  /// 0.50 point.
  /// </summary>
  Pt050 = 4,
  /// <summary>
  /// 0.75 point.
  /// </summary>
  Pt075 = 6,
  /// <summary>
  /// 1.00 point. default.
  /// </summary>
  Pt100 = 8,
  /// <summary>
  /// 1.50 points.
  /// </summary>
  Pt150 = 12,
  /// <summary>
  /// 2.25 points.
  /// </summary>
  Pt225 = 18,
  /// <summary>
  /// 3.00 points.
  /// </summary>
  Pt300 = 24,
  /// <summary>
  /// 4.50 points.
  /// </summary>
  Pt450 = 36,
  /// <summary>
  /// 6.00 points.
  /// </summary>
  Pt600 = 48
}
