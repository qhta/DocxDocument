namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public interface ColorsType
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public DocumentModel.Drawings.ColorApplicationMethodKind? Method { get ; set; }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public DocumentModel.Drawings.HueDirectionKind? HueDirection { get ; set; }
  
}
