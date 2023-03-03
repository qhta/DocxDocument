namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Time Unit
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TimeUnitKind
{
  /// <summary>
  ///   Days.
  /// </summary>
  Days,

  /// <summary>
  ///   Months.
  /// </summary>
  Months,

  /// <summary>
  ///   Years.
  /// </summary>
  Years
}