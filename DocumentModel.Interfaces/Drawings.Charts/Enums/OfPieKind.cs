namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Pie of Pie or Bar of Pie Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OfPieKind
{
  /// <summary>
  ///   Pie.
  /// </summary>
  Pie,
  /// <summary>
  ///   Bar.
  /// </summary>
  Bar
}