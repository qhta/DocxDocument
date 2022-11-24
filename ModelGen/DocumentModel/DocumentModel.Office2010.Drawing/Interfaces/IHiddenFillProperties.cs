namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenFillProperties Class.
/// </summary>
public interface IHiddenFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
