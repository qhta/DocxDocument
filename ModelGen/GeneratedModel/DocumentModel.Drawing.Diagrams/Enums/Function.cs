namespace DocumentModel.Drawing.Diagrams;

public enum Function
{

  [XmlEnum("cnt")]
  Count,

  [XmlEnum("pos")]
  Position,

  [XmlEnum("revPos")]
  ReversePosition,

  [XmlEnum("posEven")]
  PositionEven,

  [XmlEnum("posOdd")]
  PositionOdd,

  [XmlEnum("var")]
  Variable,

  [XmlEnum("depth")]
  Depth,

  [XmlEnum("maxDepth")]
  MaxDepth,
}
