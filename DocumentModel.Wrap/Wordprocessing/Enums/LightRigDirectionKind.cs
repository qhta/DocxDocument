namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LightRigDirectionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LightRigDirectionKind
{
  /// <summary>
  ///   tl.
  /// </summary>
  TopLeft,

  /// <summary>
  ///   t.
  /// </summary>
  Top,

  /// <summary>
  ///   tr.
  /// </summary>
  TopRight,

  /// <summary>
  ///   l.
  /// </summary>
  Left,

  /// <summary>
  ///   r.
  /// </summary>
  Right,

  /// <summary>
  ///   bl.
  /// </summary>
  BottomLeft,

  /// <summary>
  ///   b.
  /// </summary>
  Bottom,

  /// <summary>
  ///   br.
  /// </summary>
  BottomRight
}