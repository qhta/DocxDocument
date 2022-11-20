namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CheckerTransition Class.
/// </summary>
public class CheckerTransition: ICheckerTransition
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
