namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Light Rig Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LightRigDirectionKind
{
  /// <summary>
  ///   Top Left.
  /// </summary>
  TopLeft,

  /// <summary>
  ///   Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Top Right.
  /// </summary>
  TopRight,

  /// <summary>
  ///   Left.
  /// </summary>
  Left,

  /// <summary>
  ///   Right.
  /// </summary>
  Right,

  /// <summary>
  ///   Bottom Left.
  /// </summary>
  BottomLeft,

  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Bottom Right.
  /// </summary>
  BottomRight
}