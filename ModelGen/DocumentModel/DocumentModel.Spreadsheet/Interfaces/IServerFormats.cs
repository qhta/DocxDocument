namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Formats.
/// </summary>
public interface IServerFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IServerFormat>? ServerFormats { get ; set; }
  
}
