namespace DocumentModel.Drawing.Diagrams;

public enum Connection
{

  [XmlEnum("parOf")]
  ParentOf,

  [XmlEnum("presOf")]
  PresentationOf,

  [XmlEnum("presParOf")]
  PresentationParentOf,

  [XmlEnum("unknownRelationship")]
  UnknownRelationship,
}
