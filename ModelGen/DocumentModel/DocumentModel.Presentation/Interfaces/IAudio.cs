namespace DocumentModel.Presentation;

/// <summary>
/// Audio.
/// </summary>
public interface IAudio // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Is Narration
  /// </summary>
  public System.Boolean? IsNarration { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonMediaNode? CommonMediaNode { get ; set; }
  
}
