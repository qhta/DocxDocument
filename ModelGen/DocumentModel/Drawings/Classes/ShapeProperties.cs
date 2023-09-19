namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the visual shape properties that can be applied to a shape.
/// </summary>
public partial class ShapeProperties
{
  
  /// <summary>
  ///   Specifies that the picture should be rendered using only black and white coloring. That is the coloring information for the picture should be converted to either black or white when rendering the picture.
  /// </summary>
  [SchemaAttr("bwMode")]
  public DocumentModel.Drawings.BlackWhiteModeValues? BlackWhiteMode { get; set; }
  
  
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  public DocumentModel.Drawings.Transform2D? Transform2D { get; set; }
  
  public DocumentModel.Drawings.CustomGeometry? CustomGeometry { get; set; }
  
  public DocumentModel.Drawings.PresetGeometry? PresetGeometry { get; set; }
  
  public Boolean? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public Boolean? GroupFill { get; set; }
  
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType { get; set; }
  
  public DocumentModel.Drawings.Shape3DType? Shape3DType { get; set; }
  
  public DocumentModel.Drawings.ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
  
}
