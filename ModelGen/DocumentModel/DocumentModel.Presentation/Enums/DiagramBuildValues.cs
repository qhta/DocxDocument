namespace DocumentModel.Presentation;

/// <summary>
/// Diagram Build Types
/// </summary>
public enum DiagramBuildValues
{
  /// <summary>
  /// Diagram Build Type Enum ( Whole ).
  /// </summary>
  [XmlEnum("whole")]
  Whole,
  
  /// <summary>
  /// Diagram Build Type Enum ( Depth By Node ).
  /// </summary>
  [XmlEnum("depthByNode")]
  DepthByNode,
  
  /// <summary>
  /// Diagram Build Type Enum ( Depth By Branch ).
  /// </summary>
  [XmlEnum("depthByBranch")]
  DepthByBranch,
  
  /// <summary>
  /// Diagram Build Type Enum ( Breadth By Node ).
  /// </summary>
  [XmlEnum("breadthByNode")]
  BreadthByNode,
  
  /// <summary>
  /// Diagram Build Type Enum ( Breadth By Level ).
  /// </summary>
  [XmlEnum("breadthByLvl")]
  BreadthByLevel,
  
  /// <summary>
  /// Diagram Build Type Enum ( Clockwise ).
  /// </summary>
  [XmlEnum("cw")]
  Clockwise,
  
  /// <summary>
  /// Diagram Build Type Enum ( Clockwise-In ).
  /// </summary>
  [XmlEnum("cwIn")]
  ClockwiseIn,
  
  /// <summary>
  /// Diagram Build Type Enum ( Clockwise-Out ).
  /// </summary>
  [XmlEnum("cwOut")]
  ClockwiseOut,
  
  /// <summary>
  /// Diagram Build Type Enum ( Counter-Clockwise ).
  /// </summary>
  [XmlEnum("ccw")]
  CounterClockwise,
  
  /// <summary>
  /// Diagram Build Type Enum ( Counter-Clockwise-In ).
  /// </summary>
  [XmlEnum("ccwIn")]
  CounterClockwiseIn,
  
  /// <summary>
  /// Diagram Build Type Enum ( Counter-Clockwise-Out ).
  /// </summary>
  [XmlEnum("ccwOut")]
  CounterClockwiseOut,
  
  /// <summary>
  /// Diagram Build Type Enum ( In-By-Ring ).
  /// </summary>
  [XmlEnum("inByRing")]
  InByRing,
  
  /// <summary>
  /// Diagram Build Type Enum ( Out-By-Ring ).
  /// </summary>
  [XmlEnum("outByRing")]
  OutByRing,
  
  /// <summary>
  /// Diagram Build Type Enum ( Up ).
  /// </summary>
  [XmlEnum("up")]
  Up,
  
  /// <summary>
  /// Diagram Build Type Enum ( Down ).
  /// </summary>
  [XmlEnum("down")]
  Down,
  
  /// <summary>
  /// Diagram Build Type Enum ( All At Once ).
  /// </summary>
  [XmlEnum("allAtOnce")]
  AllAtOnce,
  
  /// <summary>
  /// Diagram Build Type Enum ( Custom ).
  /// </summary>
  [XmlEnum("cust")]
  Custom,
  
}
