namespace DocumentModel.Drawings.Charts;

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