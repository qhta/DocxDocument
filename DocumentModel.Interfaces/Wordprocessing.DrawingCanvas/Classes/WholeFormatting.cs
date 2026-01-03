using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
///   Defines the WholeFormatting Class.
/// </summary>
public interface WholeFormatting: IModelElement
{
  /// <summary>
  ///   Outline.
  /// </summary>
  public LineProperties? Outline { get; set; }
  public EffectList? EffectList { get; set; }
  public EffectDag? EffectDag { get; set; }
}