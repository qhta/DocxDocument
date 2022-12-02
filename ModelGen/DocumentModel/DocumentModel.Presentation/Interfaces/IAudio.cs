namespace DocumentModel.Presentation;

/// <summary>
/// Audio.
/// </summary>
public interface IAudio // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Is Narration
  /// </summary>
  public Boolean? IsNarration { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public ICommonMediaNode? CommonMediaNode { get ; set; }
  
}
