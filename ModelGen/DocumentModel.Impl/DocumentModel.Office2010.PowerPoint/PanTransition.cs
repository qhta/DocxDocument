namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the PanTransition Class.
/// </summary>
public class PanTransition: IPanTransition
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionSlideDirectionValues? Direction
  {
    get;
    set;
  }
  
}
