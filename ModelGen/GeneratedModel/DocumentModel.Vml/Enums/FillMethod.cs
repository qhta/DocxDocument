namespace DocumentModel.Vml;

public enum FillMethod
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("linear")]
  Linear,
  
  [XmlEnum("sigma")]
  Sigma,
  
  [XmlEnum("any")]
  Any,
  
  [XmlEnum("linear sigma")]
  Linearsigma,
}
