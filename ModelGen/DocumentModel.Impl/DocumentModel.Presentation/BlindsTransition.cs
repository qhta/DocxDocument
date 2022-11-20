namespace DocumentModel.Presentation;

/// <summary>
/// Defines the BlindsTransition Class.
/// </summary>
public class BlindsTransition: IBlindsTransition
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
