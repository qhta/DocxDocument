namespace DocumentModel.Drawing;

/// <summary>
/// Color Change Effect.
/// </summary>
public interface IColorChange // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha { get ; set; }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public IColorFrom? ColorFrom { get ; set; }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public IColorTo? ColorTo { get ; set; }
  
}
