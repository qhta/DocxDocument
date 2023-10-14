namespace DocumentModel.Math;


/// <summary>
///   Equation Array Properties.
/// </summary>
public partial class EquationArrayProperties
{
  
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentKind? BaseJustification { get; set; }
  
  
  /// <summary>
  ///   Maximum Distribution.
  /// </summary>
  public DocumentModel.Math.MaxDistribution? MaxDistribution { get; set; }
  
  
  /// <summary>
  ///   Object Distribution.
  /// </summary>
  public DocumentModel.Math.ObjectDistribution? ObjectDistribution { get; set; }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public DocumentModel.Math.RowSpacingRule? RowSpacingRule { get; set; }
  
  
  /// <summary>
  ///   Row Spacing (Equation Array).
  /// </summary>
  public DocumentModel.Math.RowSpacing? RowSpacing { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
