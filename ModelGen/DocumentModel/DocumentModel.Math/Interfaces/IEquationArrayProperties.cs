namespace DocumentModel.Math;

/// <summary>
/// Equation Array Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IMaxDistribution))]
[ChildElementInfo(typeof(DocumentModel.Math.IObjectDistribution))]
[ChildElementInfo(typeof(DocumentModel.Math.IRowSpacingRule))]
[ChildElementInfo(typeof(DocumentModel.Math.IRowSpacing))]
[ChildElementInfo(typeof(DocumentModel.Math.IBaseJustification))]
public interface IEquationArrayProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
