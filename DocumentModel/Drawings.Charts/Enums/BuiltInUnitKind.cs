namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Built-In Unit
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BuiltInUnitKind
{
  /// <summary>
  ///   Hundreds.
  /// </summary>
  Hundreds,

  /// <summary>
  ///   Thousands.
  /// </summary>
  Thousands,

  /// <summary>
  ///   Ten Thousands.
  /// </summary>
  TenThousands,

  /// <summary>
  ///   Hundred Thousands.
  /// </summary>
  HundredThousands,

  /// <summary>
  ///   Millions.
  /// </summary>
  Millions,

  /// <summary>
  ///   Ten Millions.
  /// </summary>
  TenMillions,

  /// <summary>
  ///   Hundred Millions.
  /// </summary>
  HundredMillions,

  /// <summary>
  ///   Billions.
  /// </summary>
  Billions,

  /// <summary>
  ///   Trillions.
  /// </summary>
  Trillions
}