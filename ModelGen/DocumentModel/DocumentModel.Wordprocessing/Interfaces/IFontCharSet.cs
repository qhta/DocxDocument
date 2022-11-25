namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public interface IFontCharSet // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public DocumentModel.Wordprocessing.StrictCharacterSet? StrictCharacterSet { get ; set; }
  
}
