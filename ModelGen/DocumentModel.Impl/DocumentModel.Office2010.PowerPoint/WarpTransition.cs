namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the WarpTransition Class.
/// </summary>
public class WarpTransition: IWarpTransition
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
