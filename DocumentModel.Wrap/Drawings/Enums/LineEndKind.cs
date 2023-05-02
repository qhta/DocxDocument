namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Line End Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LineEndKind
{
  /// <summary>
  ///   None.
  /// </summary>
  None,

  /// <summary>
  ///   Triangle Arrow Head.
  /// </summary>
  Triangle,

  /// <summary>
  ///   Stealth Arrow.
  /// </summary>
  Stealth,

  /// <summary>
  ///   Diamond.
  /// </summary>
  Diamond,

  /// <summary>
  ///   Oval.
  /// </summary>
  Oval,

  /// <summary>
  ///   Arrow Head.
  /// </summary>
  Arrow
}