namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a list of effects. Effects in an effectLst are applied in the default order by the rendering engine. The following diagrams illustrate the order in which effects are applied, both for shapes and for group shapes.
/// </summary>
public partial class EffectList
{
  
  /// <summary>
  ///   Blur Effect.
  /// </summary>
  public DMD.Blur? Blur { get; set; }
  
  
  /// <summary>
  ///   FillOverlay.
  /// </summary>
  public DMD.FillOverlay? FillOverlay { get; set; }
  
  
  /// <summary>
  ///   Glow.
  /// </summary>
  public DMD.Glow? Glow { get; set; }
  
  
  /// <summary>
  ///   InnerShadow.
  /// </summary>
  public DMD.InnerShadow? InnerShadow { get; set; }
  
  
  /// <summary>
  ///   OuterShadow.
  /// </summary>
  public DMD.OuterShadow? OuterShadow { get; set; }
  
  
  /// <summary>
  ///   PresetShadow.
  /// </summary>
  public DMD.PresetShadow? PresetShadow { get; set; }
  
  
  /// <summary>
  ///   Reflection.
  /// </summary>
  public DMD.Reflection? Reflection { get; set; }
  
  
  /// <summary>
  ///   SoftEdge.
  /// </summary>
  public DMD.SoftEdge? SoftEdge { get; set; }
  
}
