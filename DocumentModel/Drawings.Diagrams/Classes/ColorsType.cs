namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public partial class ColorsType
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind? Method { get; set; }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public DocumentModel.Drawings.Diagrams.HueDirectionKind? HueDirection { get; set; }
  
}
