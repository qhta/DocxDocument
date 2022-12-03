namespace DocumentModel.Presentation;

/// <summary>
/// Audio.
/// </summary>
public interface Audio // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Is Narration
  /// </summary>
  public Boolean? IsNarration { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public CommonMediaNode? CommonMediaNode { get ; set; }
  
}
