namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PushTransition Class.
/// </summary>
public class PushTransition: IPushTransition
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
