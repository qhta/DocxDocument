namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalJustificationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalJustificationKind
{
  /// <summary>
  ///   Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  Bottom
}