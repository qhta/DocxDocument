namespace DocumentModel.Math;


/// <summary>
///   Equation Array Properties.
/// </summary>
public partial class EquationArrayProperties
{
  
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  public DocumentModel.Math.VerticalAlignmentValues? BaseJustification { get; set; }
  
  
  /// <summary>
  ///   Maximum Distribution.
  /// </summary>
  public DocumentModel.Math.BooleanValues? MaxDistribution { get; set; }
  
  
  /// <summary>
  ///   Object Distribution.
  /// </summary>
  public DocumentModel.Math.BooleanValues? ObjectDistribution { get; set; }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  public Int64? RowSpacingRule { get; set; }
  
  
  /// <summary>
  ///   Row Spacing (Equation Array).
  /// </summary>
  public UInt16? RowSpacing { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
