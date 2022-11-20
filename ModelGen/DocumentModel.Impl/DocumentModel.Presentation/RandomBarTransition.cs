namespace DocumentModel.Presentation;

/// <summary>
/// Defines the RandomBarTransition Class.
/// </summary>
public class RandomBarTransition: IRandomBarTransition
{
  /// <summary>
  /// Transition Direction
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Direction
  {
    get;
    set;
  }
  
}
