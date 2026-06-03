namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the AxisType enumeration.
/// Used in types such as AxisList, AxisType, CategoryAxis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AxisType
{
  /// <summary>
  ///   Self.
  /// </summary>
  [OpenXmlEnumValue("Self")]
  Self,
  /// <summary>
  ///   Child.
  /// </summary>
  [OpenXmlEnumValue("Child")]
  Child,
  /// <summary>
  ///   Descendant.
  /// </summary>
  [OpenXmlEnumValue("Descendant")]
  Descendant,
  /// <summary>
  ///   Descendant or Self.
  /// </summary>
  [OpenXmlEnumValue("DescendantOrSelf")]
  DescendantOrSelf,
  /// <summary>
  ///   Parent.
  /// </summary>
  [OpenXmlEnumValue("Parent")]
  Parent,
  /// <summary>
  ///   Ancestor.
  /// </summary>
  [OpenXmlEnumValue("Ancestor")]
  Ancestor,
  /// <summary>
  ///   Ancestor or Self.
  /// </summary>
  [OpenXmlEnumValue("AncestorOrSelf")]
  AncestorOrSelf,
  /// <summary>
  ///   Follow Sibling.
  /// </summary>
  [OpenXmlEnumValue("FollowSibling")]
  FollowSibling,
  /// <summary>
  ///   Preceding Sibling.
  /// </summary>
  [OpenXmlEnumValue("PrecedingSibling")]
  PrecedingSibling,
  /// <summary>
  ///   Follow.
  /// </summary>
  [OpenXmlEnumValue("Follow")]
  Follow,
  /// <summary>
  ///   Preceding.
  /// </summary>
  [OpenXmlEnumValue("Preceding")]
  Preceding,
  /// <summary>
  ///   Root.
  /// </summary>
  [OpenXmlEnumValue("Root")]
  Root,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None
}

