namespace DocumentModel.Presentation;

/// <summary>
/// Video.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonMediaNode))]
public class Video: IVideo
{
  /// <summary>
  /// Full Screen
  /// </summary>
  public bool? FullScreen
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
