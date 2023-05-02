namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   One by One Animation Value Definition
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AnimateOneByOneKind
{
  /// <summary>
  ///   Disable One-by-One.
  /// </summary>
  None,

  /// <summary>
  ///   One By One.
  /// </summary>
  One,

  /// <summary>
  ///   By Branch One By One.
  /// </summary>
  Branch
}