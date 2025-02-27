namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalTextAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalTextAlignmentKind
{
  /// <summary>
  ///   Align Text at Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Align Text at Center.
  /// </summary>
  Center,

  /// <summary>
  ///   Align Text at Baseline.
  /// </summary>
  Baseline,

  /// <summary>
  ///   Align Text at Bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Automatically Determine Alignment.
  /// </summary>
  Auto
}