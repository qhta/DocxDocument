namespace DocumentModel;

/// <summary>
///   Defines the TaskSizesValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TaskSizesKind
{
  /// <summary>
  ///   largeMediumSmall.
  /// </summary>
  LargeMediumSmall,
  /// <summary>
  ///   largeMedium.
  /// </summary>
  LargeMedium,
  /// <summary>
  ///   large.
  /// </summary>
  Large,
  /// <summary>
  ///   mediumSmall.
  /// </summary>
  MediumSmall,
  /// <summary>
  ///   medium.
  /// </summary>
  Medium,
  /// <summary>
  ///   small.
  /// </summary>
  Small
}