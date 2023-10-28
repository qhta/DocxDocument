namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Shape Properties.
/// </summary>
public partial class ShapeProperties
{
  
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  public DMD.Transform2D? Transform2D { get; set; }
  
  public DMD.CustomGeometry? CustomGeometry { get; set; }
  
  public DMD.PresetGeometry? PresetGeometry { get; set; }
  
  public DMD.NoFill? NoFill { get; set; }
  
  public DMD.SolidFill? SolidFill { get; set; }
  
  public DMD.GradientFill? GradientFill { get; set; }
  
  public DMD.BlipFill? BlipFill { get; set; }
  
  public DMD.PatternFill? PatternFill { get; set; }
  
  public DMD.GroupFill? GroupFill { get; set; }
  
  public DMD.Outline? Outline { get; set; }
  
  public DMD.EffectList? EffectList { get; set; }
  
  public DMD.EffectDag? EffectDag { get; set; }
  
  public DMD.Scene3DType? Scene3DType { get; set; }
  
  public DMD.Shape3DType? Shape3DType { get; set; }
  
  public DMD.ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
  
}
