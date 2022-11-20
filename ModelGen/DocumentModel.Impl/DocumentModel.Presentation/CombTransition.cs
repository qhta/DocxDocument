namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CombTransition Class.
/// </summary>
public class CombTransition: ICombTransition
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
