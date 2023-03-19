namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontCharSet Class.
/// </summary>
public class FontCharSet: ModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public String? Val { get; set; }

  /// <summary>
  ///   characterSet
  /// </summary>
  public StrictCharacterSet? StrictCharacterSet { get; set; }
}