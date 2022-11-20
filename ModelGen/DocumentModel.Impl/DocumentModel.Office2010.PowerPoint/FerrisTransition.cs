namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the FerrisTransition Class.
/// </summary>
public class FerrisTransition: IFerrisTransition
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public TransitionLeftRightDirectionTypeValues? Direction
  {
    get;
    set;
  }
  
}
