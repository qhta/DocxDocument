namespace DocumentModel.Drawing.Diagrams;

public enum HierarchyBranchStyle
{

  [XmlEnum("l")]
  Left,

  [XmlEnum("r")]
  Right,

  [XmlEnum("hang")]
  Hanging,

  [XmlEnum("std")]
  Standard,

  [XmlEnum("init")]
  Initial,
}
