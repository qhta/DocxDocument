namespace DocumentModel.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public interface EffectList
{
  /// <summary>
  /// Blur Effect.
  /// </summary>
  public DocumentModel.Drawings.Blur? Blur { get ; set; }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  public DocumentModel.Drawings.FillOverlay? FillOverlay { get ; set; }
  
  /// <summary>
  /// Glow.
  /// </summary>
  public DocumentModel.Drawings.Glow? Glow { get ; set; }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  public DocumentModel.Drawings.InnerShadow? InnerShadow { get ; set; }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  public DocumentModel.Drawings.OuterShadow? OuterShadow { get ; set; }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  public DocumentModel.Drawings.PresetShadow? PresetShadow { get ; set; }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  public DocumentModel.Drawings.Reflection? Reflection { get ; set; }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  public DocumentModel.Drawings.SoftEdge? SoftEdge { get ; set; }
  
}
