namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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