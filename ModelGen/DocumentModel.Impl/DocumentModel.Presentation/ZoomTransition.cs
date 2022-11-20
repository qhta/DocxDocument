namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ZoomTransition Class.
/// </summary>
public class ZoomTransition: IZoomTransition
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionValues? Direction
  {
    get;
    set;
  }
  
}
