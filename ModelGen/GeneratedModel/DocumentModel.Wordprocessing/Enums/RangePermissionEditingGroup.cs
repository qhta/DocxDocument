namespace DocumentModel.Wordprocessing;

public enum RangePermissionEditingGroup
{

  [XmlEnum("none")]
  None,

  [XmlEnum("everyone")]
  Everyone,

  [XmlEnum("administrators")]
  Administrators,

  [XmlEnum("contributors")]
  Contributors,

  [XmlEnum("editors")]
  Editors,

  [XmlEnum("owners")]
  Owners,

  [XmlEnum("current")]
  Current,
}
