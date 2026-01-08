namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Child Order
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ChildOrderKind
{
  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,
  /// <summary>
  ///   Top.
  /// </summary>
  Top
}