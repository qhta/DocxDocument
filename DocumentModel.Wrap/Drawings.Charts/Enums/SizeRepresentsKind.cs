namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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