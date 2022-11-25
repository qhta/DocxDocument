namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenFillProperties Class.
/// </summary>
public interface IHiddenFillProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
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
