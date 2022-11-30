namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Items.
/// </summary>
public interface IPage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPageItem>? PageItems { get ; set; }
  
}
