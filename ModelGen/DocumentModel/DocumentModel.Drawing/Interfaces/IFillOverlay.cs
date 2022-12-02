namespace DocumentModel.Drawing;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public interface IFillOverlay // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blend
  /// </summary>
  public BlendMode? Blend { get ; set; }
  
  /// <summary>
  /// NoFill.
  /// </summary>
  public Boolean? NoFill { get ; set; }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public ISolidFill? SolidFill { get ; set; }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public IGradientFill? GradientFill { get ; set; }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public IBlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public IPatternFill? PatternFill { get ; set; }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public Boolean? GroupFill { get ; set; }
  
}
