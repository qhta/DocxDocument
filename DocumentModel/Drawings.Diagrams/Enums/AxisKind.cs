namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Axis Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AxisKind
{
  /// <summary>
  ///   Self.
  /// </summary>
  Self,

  /// <summary>
  ///   Child.
  /// </summary>
  Child,

  /// <summary>
  ///   Descendant.
  /// </summary>
  Descendant,

  /// <summary>
  ///   Descendant or Self.
  /// </summary>
  DescendantOrSelf,

  /// <summary>
  ///   Parent.
  /// </summary>
  Parent,

  /// <summary>
  ///   Ancestor.
  /// </summary>
  Ancestor,

  /// <summary>
  ///   Ancestor or Self.
  /// </summary>
  AncestorOrSelf,

  /// <summary>
  ///   Follow Sibling.
  /// </summary>
  FollowSibling,

  /// <summary>
  ///   Preceding Sibling.
  /// </summary>
  PrecedingSibling,

  /// <summary>
  ///   Follow.
  /// </summary>
  Follow,

  /// <summary>
  ///   Preceding.
  /// </summary>
  Preceding,

  /// <summary>
  ///   Root.
  /// </summary>
  Root,

  /// <summary>
  ///   None.
  /// </summary>
  None
}