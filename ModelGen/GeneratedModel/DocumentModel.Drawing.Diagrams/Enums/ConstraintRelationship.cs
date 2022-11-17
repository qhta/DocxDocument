namespace DocumentModel.Drawing.Diagrams;

public enum ConstraintRelationship
{
  
  [XmlEnum("self")]
  Self,
  
  [XmlEnum("ch")]
  Child,
  
  [XmlEnum("des")]
  Descendant,
}
