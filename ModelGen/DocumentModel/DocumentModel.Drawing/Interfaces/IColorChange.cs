namespace DocumentModel.Drawing;

/// <summary>
/// Color Change Effect.
/// </summary>
public interface IColorChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public System.Boolean? UseAlpha { get ; set; }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public DocumentModel.Drawing.IColorFrom? ColorFrom { get ; set; }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public DocumentModel.Drawing.IColorTo? ColorTo { get ; set; }
  
}
