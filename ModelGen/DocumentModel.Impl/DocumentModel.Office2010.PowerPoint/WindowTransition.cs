namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the WindowTransition Class.
/// </summary>
public class WindowTransition: IWindowTransition
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
