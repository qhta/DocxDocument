namespace DocumentModel.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public interface EquationArrayProperties
{
  /// <summary>
  /// Equation Array Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentKind? BaseJustification { get ; set; }
  
  /// <summary>
  /// Maximum Distribution.
  /// </summary>
  public DocumentModel.Math.BooleanKind? MaxDistribution { get ; set; }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ObjectDistribution { get ; set; }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public Int32? RowSpacingRule { get ; set; }
  
  /// <summary>
  /// Row Spacing (Equation Array).
  /// </summary>
  public UInt16? RowSpacing { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
