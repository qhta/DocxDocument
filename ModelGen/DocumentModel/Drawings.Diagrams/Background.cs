namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Background Formatting.
/// </summary>
public partial class Background
{
  public DMD.NoFill? NoFill { get; set; }
  
  public DMD.SolidFill? SolidFill { get; set; }
  
  public DMD.GradientFill? GradientFill { get; set; }
  
  public DMD.BlipFill? BlipFill { get; set; }
  
  public DMD.PatternFill? PatternFill { get; set; }
  
  public DMD.GroupFill? GroupFill { get; set; }
  
  public DMD.EffectList? EffectList { get; set; }
  
  public DMD.EffectDag? EffectDag { get; set; }
  
}
