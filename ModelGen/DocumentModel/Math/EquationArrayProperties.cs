namespace DocumentModel.Math;


/// <summary>
///   Equation Array Properties.
/// </summary>
public partial class EquationArrayProperties
{
  
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  public DMM.VerticalAlignmentKind? BaseJustification { get; set; }
  
  
  /// <summary>
  ///   Maximum Distribution.
  /// </summary>
  public DMM.MaxDistribution? MaxDistribution { get; set; }
  
  
  /// <summary>
  ///   Object Distribution.
  /// </summary>
  public DMM.ObjectDistribution? ObjectDistribution { get; set; }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public DMM.RowSpacingRule? RowSpacingRule { get; set; }
  
  
  /// <summary>
  ///   Row Spacing (Equation Array).
  /// </summary>
  public DMM.RowSpacing? RowSpacing { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DMM.ControlProperties? ControlProperties { get; set; }
  
}
