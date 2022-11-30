namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PageFields Class.
/// </summary>
public interface IPageFields // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPageField>? PageFields { get ; set; }
  
}
