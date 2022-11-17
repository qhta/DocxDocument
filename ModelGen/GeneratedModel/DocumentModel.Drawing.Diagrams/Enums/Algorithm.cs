namespace DocumentModel.Drawing.Diagrams;

public enum Algorithm
{
  
  [XmlEnum("composite")]
  Composite,
  
  [XmlEnum("conn")]
  Connector,
  
  [XmlEnum("cycle")]
  Cycle,
  
  [XmlEnum("hierChild")]
  HierarchyChild,
  
  [XmlEnum("hierRoot")]
  HierarchyRoot,
  
  [XmlEnum("pyra")]
  Pyramid,
  
  [XmlEnum("lin")]
  Linear,
  
  [XmlEnum("sp")]
  Space,
  
  [XmlEnum("tx")]
  Text,
  
  [XmlEnum("snake")]
  Snake,
}
