namespace DocumentModel.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public class EquationArrayProperties
{
  /// <summary>
  /// Equation Array Base Justification.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification
  {
    get;
    set;
  }
  
  /// <summary>
  /// Maximum Distribution.
  /// </summary>
  public BooleanKind? MaxDistribution
  {
    get;
    set;
  }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  public BooleanKind? ObjectDistribution
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
