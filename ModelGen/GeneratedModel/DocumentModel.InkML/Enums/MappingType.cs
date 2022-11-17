namespace DocumentModel.InkML;

public enum MappingType
{
  
  [XmlEnum("identity")]
  Identity,
  
  [XmlEnum("lookup")]
  Lookup,
  
  [XmlEnum("affine")]
  Affine,
  
  [XmlEnum("mathml")]
  MathML,
  
  [XmlEnum("product")]
  Product,
  
  [XmlEnum("unknown")]
  Unknown,
}
