namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public interface FontCharSet
{
  /// <summary>
  /// val
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public DocumentModel.Wordprocessing.StrictCharacterSet? StrictCharacterSet { get ; set; }
  
}
