namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public interface IColorsType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ColorApplicationMethodKind? Method { get ; set; }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public DocumentModel.Drawing.Diagrams.HueDirectionKind? HueDirection { get ; set; }
  
}
