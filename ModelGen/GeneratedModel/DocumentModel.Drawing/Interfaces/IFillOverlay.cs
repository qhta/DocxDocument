namespace DocumentModel.Drawing;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
public interface IFillOverlay // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blend
  /// </summary>
  public BlendMode? Blend { get ; set; }
  
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
  public IGroupFill? GroupFill { get ; set; }
  
}
