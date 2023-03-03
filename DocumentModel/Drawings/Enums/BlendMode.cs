namespace DocumentModel.Drawings;

/// <summary>
///   Blend Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BlendMode
{
  /// <summary>
  ///   Overlay.
  /// </summary>
  Overlay,

  /// <summary>
  ///   Multiply.
  /// </summary>
  Multiply,

  /// <summary>
  ///   Screen.
  /// </summary>
  Screen,

  /// <summary>
  ///   Darken.
  /// </summary>
  Darken,

  /// <summary>
  ///   Lighten.
  /// </summary>
  Lighten
}