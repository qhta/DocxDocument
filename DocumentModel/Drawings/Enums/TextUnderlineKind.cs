namespace DocumentModel.Drawings;

/// <summary>
///   Text Underline Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextUnderlineKind
{
  /// <summary>
  ///   Text Underline Enum ( None ).
  /// </summary>
  None,

  /// <summary>
  ///   Text Underline Enum ( Words ).
  /// </summary>
  Words,

  /// <summary>
  ///   Text Underline Enum ( Single ).
  /// </summary>
  Single,

  /// <summary>
  ///   Text Underline Enum ( Double ).
  /// </summary>
  Double,

  /// <summary>
  ///   Text Underline Enum ( Heavy ).
  /// </summary>
  Heavy,

  /// <summary>
  ///   Text Underline Enum ( Dotted ).
  /// </summary>
  Dotted,

  /// <summary>
  ///   Text Underline Enum ( Heavy Dotted  ).
  /// </summary>
  HeavyDotted,

  /// <summary>
  ///   Text Underline Enum ( Dashed ).
  /// </summary>
  Dash,

  /// <summary>
  ///   Text Underline Enum ( Heavy Dashed ).
  /// </summary>
  DashHeavy,

  /// <summary>
  ///   Text Underline Enum ( Long Dashed ).
  /// </summary>
  DashLong,

  /// <summary>
  ///   Text Underline Enum ( Heavy Long Dashed ).
  /// </summary>
  DashLongHeavy,

  /// <summary>
  ///   Text Underline Enum ( Dot Dash ).
  /// </summary>
  DotDash,

  /// <summary>
  ///   Text Underline Enum ( Heavy Dot Dash ).
  /// </summary>
  DotDashHeavy,

  /// <summary>
  ///   Text Underline Enum ( Dot Dot Dash ).
  /// </summary>
  DotDotDash,

  /// <summary>
  ///   Text Underline Enum ( Heavy Dot Dot Dash ).
  /// </summary>
  DotDotDashHeavy,

  /// <summary>
  ///   Text Underline Enum ( Wavy ).
  /// </summary>
  Wavy,

  /// <summary>
  ///   Text Underline Enum ( Heavy Wavy ).
  /// </summary>
  WavyHeavy,

  /// <summary>
  ///   Text Underline Enum ( Double Wavy ).
  /// </summary>
  WavyDouble
}