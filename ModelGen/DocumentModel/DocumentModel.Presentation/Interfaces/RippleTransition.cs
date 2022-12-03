namespace DocumentModel.Presentation;

/// <summary>
/// Defines the RippleTransition Class.
/// </summary>
public interface RippleTransition // : System.Boolean
{
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Direction { get ; set; }
  
}
