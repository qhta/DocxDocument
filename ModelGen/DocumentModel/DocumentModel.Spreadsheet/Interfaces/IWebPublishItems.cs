namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishItems Class.
/// </summary>
public interface IWebPublishItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Web Publishing Items Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IWebPublishItem>? WebPublishItems { get ; set; }
  
}
