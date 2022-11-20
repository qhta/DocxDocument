namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the DoorsTransition Class.
/// </summary>
public class DoorsTransition: IDoorsTransition
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
