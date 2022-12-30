namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
public partial class Whole
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
}
