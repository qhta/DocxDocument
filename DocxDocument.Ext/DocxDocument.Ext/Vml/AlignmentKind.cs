namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Alignment Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum AlignmentKind
{
  /// <summary>
  ///   Top Alignment.
  /// </summary>
  Top,

  /// <summary>
  ///   Middle Alignment.
  /// </summary>
  Middle,

  /// <summary>
  ///   Bottom Alignment.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Left Alignment.
  /// </summary>
  Left,

  /// <summary>
  ///   Center Alignment.
  /// </summary>
  Center,

  /// <summary>
  ///   Right Alignment.
  /// </summary>
  Right
}