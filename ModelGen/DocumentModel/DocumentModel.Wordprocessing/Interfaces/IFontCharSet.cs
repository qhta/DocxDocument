namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public interface IFontCharSet // : DocumentModel.ITypedOpenXmlLeafElement
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
