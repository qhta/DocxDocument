namespace DocumentModel.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
public interface IEquationArrayProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Equation Array Base Justification.
  /// </summary>
  public IBaseJustification? BaseJustification { get ; set; }
  
  /// <summary>
  /// Maximum Distribution.
  /// </summary>
  public IMaxDistribution? MaxDistribution { get ; set; }
  
  /// <summary>
  /// Object Distribution.
  /// </summary>
  public IObjectDistribution? ObjectDistribution { get ; set; }
  
  /// <summary>
  /// Row Spacing Rule.
  /// </summary>
  public IRowSpacingRule? RowSpacingRule { get ; set; }
  
  /// <summary>
  /// Row Spacing (Equation Array).
  /// </summary>
  public IRowSpacing? RowSpacing { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
