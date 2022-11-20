namespace DocumentModel.Presentation;

/// <summary>
/// Audio.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonMediaNode))]
public class Audio: IAudio
{
  /// <summary>
  /// Is Narration
  /// </summary>
  public bool? IsNarration
  {
    get;
    set;
  }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public ICommonMediaNode? CommonMediaNode
  {
    get;
    set;
  }
  
}
