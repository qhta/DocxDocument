namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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