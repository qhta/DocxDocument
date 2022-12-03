namespace DocumentModel.Drawings;

/// <summary>
/// Font.
/// </summary>
public interface SupplementalFont // : System.Boolean
{
  /// <summary>
  /// Script
  /// </summary>
  public String? Script { get ; set; }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public String? Typeface { get ; set; }
  
}
