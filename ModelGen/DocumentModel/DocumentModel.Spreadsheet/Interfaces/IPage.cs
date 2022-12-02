namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Items.
/// </summary>
public interface IPage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPageItem>? PageItems { get ; set; }
  
}
