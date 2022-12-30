namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
/// Defines the WholeFormatting Class.
/// </summary>
public partial class WholeFormatting
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawings.Outline? Outline { get; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
}
