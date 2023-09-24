namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a list of effects. Effects in an effectLst are applied in the default order by the rendering engine. The following diagrams illustrate the order in which effects are applied, both for shapes and for group shapes.
/// </summary>
public partial class EffectList
{
  
  /// <summary>
  ///   Blur Effect.
  /// </summary>
  public Blur? Blur { get; set; }
  
  
  /// <summary>
  ///   FillOverlay.
  /// </summary>
  public FillOverlay? FillOverlay { get; set; }
  
  
  /// <summary>
  ///   Glow.
  /// </summary>
  public Glow? Glow { get; set; }
  
  
  /// <summary>
  ///   InnerShadow.
  /// </summary>
  public InnerShadow? InnerShadow { get; set; }
  
  
  /// <summary>
  ///   OuterShadow.
  /// </summary>
  public OuterShadow? OuterShadow { get; set; }
  
  
  /// <summary>
  ///   PresetShadow.
  /// </summary>
  public PresetShadow? PresetShadow { get; set; }
  
  
  /// <summary>
  ///   Reflection.
  /// </summary>
  public Reflection? Reflection { get; set; }
  
  
  /// <summary>
  ///   SoftEdge.
  /// </summary>
  public SoftEdge? SoftEdge { get; set; }
  
}
