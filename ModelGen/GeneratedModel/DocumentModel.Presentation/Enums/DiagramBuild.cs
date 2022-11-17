namespace DocumentModel.Presentation;

public enum DiagramBuild
{

  [XmlEnum("whole")]
  Whole,

  [XmlEnum("depthByNode")]
  DepthByNode,

  [XmlEnum("depthByBranch")]
  DepthByBranch,

  [XmlEnum("breadthByNode")]
  BreadthByNode,

  [XmlEnum("breadthByLvl")]
  BreadthByLevel,

  [XmlEnum("cw")]
  Clockwise,

  [XmlEnum("cwIn")]
  ClockwiseIn,

  [XmlEnum("cwOut")]
  ClockwiseOut,

  [XmlEnum("ccw")]
  CounterClockwise,

  [XmlEnum("ccwIn")]
  CounterClockwiseIn,

  [XmlEnum("ccwOut")]
  CounterClockwiseOut,

  [XmlEnum("inByRing")]
  InByRing,

  [XmlEnum("outByRing")]
  OutByRing,

  [XmlEnum("up")]
  Up,

  [XmlEnum("down")]
  Down,

  [XmlEnum("allAtOnce")]
  AllAtOnce,

  [XmlEnum("cust")]
  Custom,
}
