namespace DocumentModel.Vml;

public enum EditAs
{
  
  [XmlEnum("canvas")]
  Canvas,
  
  [XmlEnum("orgchart")]
  OrganizationChart,
  
  [XmlEnum("radial")]
  Radial,
  
  [XmlEnum("cycle")]
  Cycle,
  
  [XmlEnum("stacked")]
  Stacked,
  
  [XmlEnum("venn")]
  Venn,
  
  [XmlEnum("bullseye")]
  Bullseye,
}
