namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the direction options for a light rig in WordprocessingML drawings.
/// This enumeration provides values for various lighting directions, supporting advanced 3D rendering and shading effects for graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LightRigDirectionKind
{

  /// <summary>
  /// Top left direction.
  /// </summary>
  TopLeft,

  /// <summary>
  /// Top direction.
  /// </summary>
  Top,

  /// <summary>
  /// Top right direction.
  /// </summary>
  TopRight,

  /// <summary>
  /// Left direction.
  /// </summary>
  Left,

  /// <summary>
  /// Right direction.
  /// </summary>
  Right,

  /// <summary>
  /// Bottom left direction.
  /// </summary>
  BottomLeft,

  /// <summary>
  /// Bottom direction.
  /// </summary>
  Bottom,

  /// <summary>
  /// Bottom right direction.
  /// </summary>
  BottomRight
}