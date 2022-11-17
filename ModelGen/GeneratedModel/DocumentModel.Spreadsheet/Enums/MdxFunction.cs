namespace DocumentModel.Spreadsheet;

public enum MdxFunction
{
  
  [XmlEnum("m")]
  CubeMember,
  
  [XmlEnum("v")]
  CubeValue,
  
  [XmlEnum("s")]
  CubeSet,
  
  [XmlEnum("c")]
  CubeSetCount,
  
  [XmlEnum("r")]
  CubeRankedMember,
  
  [XmlEnum("p")]
  CubeMemberProperty,
  
  [XmlEnum("k")]
  CubeKPIMember,
}
