namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public interface FontCharSet // : System.Boolean
{
  /// <summary>
  /// val
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public StrictCharacterSet? StrictCharacterSet { get ; set; }
  
}
