namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the MarkerStyle enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MarkerStyle
{
  /// <summary>
  ///   circle.
  /// </summary>
  Circle,
  /// <summary>
  ///   dash.
  /// </summary>
  Dash,
  /// <summary>
  ///   diamond.
  /// </summary>
  Diamond,
  /// <summary>
  ///   dot.
  /// </summary>
  Dot,
  /// <summary>
  ///   plus.
  /// </summary>
  Plus,
  /// <summary>
  ///   square.
  /// </summary>
  Square,
  /// <summary>
  ///   star.
  /// </summary>
  Star,
  /// <summary>
  ///   triangle.
  /// </summary>
  Triangle,
  /// <summary>
  ///   x.
  /// </summary>
  X
}