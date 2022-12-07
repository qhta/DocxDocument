namespace DocumentModel.Drawings;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
public class WholeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>, Whole
{
  /// <summary>
  /// Outline.
  /// </summary>
  public Outline? Outline
  {
    get;
    set;
  }
  
  public EffectList? EffectList
  {
    get;
    set;
  }
  
  public EffectDag? EffectDag
  {
    get;
    set;
  }
  
}
