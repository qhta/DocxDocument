namespace DocumentModel.Math;

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