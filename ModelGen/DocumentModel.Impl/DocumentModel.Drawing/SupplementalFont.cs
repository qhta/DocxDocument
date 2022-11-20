namespace DocumentModel.Drawing;

/// <summary>
/// Font.
/// </summary>
public class SupplementalFont: ISupplementalFont
{
  /// <summary>
  /// Script
  /// </summary>
  public string? Script
  {
    get;
    set;
  }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public string? Typeface
  {
    get;
    set;
  }
  
}
