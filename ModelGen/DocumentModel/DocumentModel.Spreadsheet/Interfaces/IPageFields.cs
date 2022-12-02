namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PageFields Class.
/// </summary>
public interface IPageFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPageField>? PageFields { get ; set; }
  
}
