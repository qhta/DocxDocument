namespace DocumentModel.Presentation;

/// <summary>
/// Defines the WipeTransition Class.
/// </summary>
public class WipeTransition: IWipeTransition
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
