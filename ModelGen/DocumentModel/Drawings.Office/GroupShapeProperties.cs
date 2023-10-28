namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the GroupShapeProperties Class.
/// </summary>
public partial class GroupShapeProperties
{
  
  /// <summary>
  ///   2D Transform for Grouped Objects.
  /// </summary>
  public DMD.TransformGroup? TransformGroup { get; set; }
  
  public DMD.NoFill? NoFill { get; set; }
  
  public DMD.SolidFill? SolidFill { get; set; }
  
  public DMD.GradientFill? GradientFill { get; set; }
  
  public DMD.BlipFill? BlipFill { get; set; }
  
  public DMD.PatternFill? PatternFill { get; set; }
  
  public DMD.GroupFill? GroupFill { get; set; }
  
  public DMD.EffectList? EffectList { get; set; }
  
  public DMD.EffectDag? EffectDag { get; set; }
  
  public DMD.Scene3DType? Scene3DType { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
