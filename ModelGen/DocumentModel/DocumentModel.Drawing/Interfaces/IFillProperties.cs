namespace DocumentModel.Drawing;

/// <summary>
/// Fill.
/// </summary>
public interface IFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NoFill.
  /// </summary>
  public INoFill? NoFill { get ; set; }
  
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
  public IGroupFill? GroupFill { get ; set; }
  
}
