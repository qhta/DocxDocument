namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public interface IColorsType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public DocumentModel.Drawing.ColorApplicationMethodKind? Method { get ; set; }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public DocumentModel.Drawing.HueDirectionKind? HueDirection { get ; set; }
  
}
