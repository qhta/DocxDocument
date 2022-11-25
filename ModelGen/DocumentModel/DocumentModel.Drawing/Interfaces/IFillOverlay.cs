namespace DocumentModel.Drawing;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public interface IFillOverlay // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blend
  /// </summary>
  public DocumentModel.Drawing.BlendMode? Blend { get ; set; }
  
  /// <summary>
  /// NoFill.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NoFill { get ; set; }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GroupFill { get ; set; }
  
}
