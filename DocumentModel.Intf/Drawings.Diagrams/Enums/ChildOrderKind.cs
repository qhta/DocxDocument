namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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