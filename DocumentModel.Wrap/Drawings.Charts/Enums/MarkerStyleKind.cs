namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Marker Style
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MarkerStyleKind
{
  /// <summary>
  ///   auto.
  /// </summary>
  Auto,

  /// <summary>
  ///   Circle.
  /// </summary>
  Circle,

  /// <summary>
  ///   Dash.
  /// </summary>
  Dash,

  /// <summary>
  ///   Diamond.
  /// </summary>
  Diamond,

  /// <summary>
  ///   Dot.
  /// </summary>
  Dot,

  /// <summary>
  ///   None.
  /// </summary>
  None,

  /// <summary>
  ///   Picture.
  /// </summary>
  Picture,

  /// <summary>
  ///   Plus.
  /// </summary>
  Plus,

  /// <summary>
  ///   Square.
  /// </summary>
  Square,

  /// <summary>
  ///   Star.
  /// </summary>
  Star,

  /// <summary>
  ///   Triangle.
  /// </summary>
  Triangle,

  /// <summary>
  ///   X.
  /// </summary>
  X
}