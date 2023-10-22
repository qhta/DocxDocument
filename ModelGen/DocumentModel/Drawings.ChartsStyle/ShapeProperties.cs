namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public partial class ShapeProperties
{
  
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  public DocumentModel.Drawings.Transform2D? Transform2D { get; set; }
  
  public DocumentModel.Drawings.CustomGeometry? CustomGeometry { get; set; }
  
  public DocumentModel.Drawings.PresetGeometry? PresetGeometry { get; set; }
  
  public DocumentModel.Drawings.NoFill? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.GroupFill? GroupFill { get; set; }
  
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType { get; set; }
  
  public DocumentModel.Drawings.Shape3DType? Shape3DType { get; set; }
  
  public DocumentModel.Drawings.ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
  
}
