namespace DocumentModel.Presentation;

/// <summary>
/// Diagram Build Types
/// </summary>
public enum DiagramBuildKind
{
  /// <summary>
  /// Diagram Build Type Enum ( Whole ).
  /// </summary>
  Whole,
  
  /// <summary>
  /// Diagram Build Type Enum ( Depth By Node ).
  /// </summary>
  DepthByNode,
  
  /// <summary>
  /// Diagram Build Type Enum ( Depth By Branch ).
  /// </summary>
  DepthByBranch,
  
  /// <summary>
  /// Diagram Build Type Enum ( Breadth By Node ).
  /// </summary>
  BreadthByNode,
  
  /// <summary>
  /// Diagram Build Type Enum ( Breadth By Level ).
  /// </summary>
  BreadthByLevel,
  
  /// <summary>
  /// Diagram Build Type Enum ( Clockwise ).
  /// </summary>
  Clockwise,
  
  /// <summary>
  /// Diagram Build Type Enum ( Clockwise-In ).
  /// </summary>
  ClockwiseIn,
  
  /// <summary>
  /// Diagram Build Type Enum ( Clockwise-Out ).
  /// </summary>
  ClockwiseOut,
  
  /// <summary>
  /// Diagram Build Type Enum ( Counter-Clockwise ).
  /// </summary>
  CounterClockwise,
  
  /// <summary>
  /// Diagram Build Type Enum ( Counter-Clockwise-In ).
  /// </summary>
  CounterClockwiseIn,
  
  /// <summary>
  /// Diagram Build Type Enum ( Counter-Clockwise-Out ).
  /// </summary>
  CounterClockwiseOut,
  
  /// <summary>
  /// Diagram Build Type Enum ( In-By-Ring ).
  /// </summary>
  InByRing,
  
  /// <summary>
  /// Diagram Build Type Enum ( Out-By-Ring ).
  /// </summary>
  OutByRing,
  
  /// <summary>
  /// Diagram Build Type Enum ( Up ).
  /// </summary>
  Up,
  
  /// <summary>
  /// Diagram Build Type Enum ( Down ).
  /// </summary>
  Down,
  
  /// <summary>
  /// Diagram Build Type Enum ( All At Once ).
  /// </summary>
  AllAtOnce,
  
  /// <summary>
  /// Diagram Build Type Enum ( Custom ).
  /// </summary>
  Custom,
  
}
