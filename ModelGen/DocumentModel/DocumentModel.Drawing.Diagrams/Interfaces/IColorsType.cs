namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public interface IColorsType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public ColorApplicationMethodValues? Method { get ; set; }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public HueDirectionValues? HueDirection { get ; set; }
  
}
