namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Background Formatting.
/// </summary>
public partial class Background
{
  public DocumentModel.Drawings.NoFill? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.GroupFill? GroupFill { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
}
