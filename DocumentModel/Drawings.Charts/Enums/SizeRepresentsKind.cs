namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Size Represents
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SizeRepresentsKind
{
  /// <summary>
  ///   Bubble Size Represents Area.
  /// </summary>
  Area,

  /// <summary>
  ///   Bubble Size Represents Width.
  /// </summary>
  Width
}