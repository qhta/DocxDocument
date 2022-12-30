namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Group Shape Properties.
/// </summary>
public partial class GroupShapeProperties
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BlackWhiteMode { get; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public DocumentModel.Drawings.TransformGroup? TransformGroup { get; set; }
  
  public Boolean? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public Boolean? GroupFill { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
