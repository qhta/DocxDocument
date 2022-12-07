namespace DocumentModel.Drawings;

/// <summary>
/// Property Set.
/// </summary>
public interface PropertySet
{
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  public PresentationLayoutVariables? PresentationLayoutVariables { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style3? Style { get ; set; }
  
}
