namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public interface IFontCharSet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public StrictCharacterSet? StrictCharacterSet { get ; set; }
  
}
