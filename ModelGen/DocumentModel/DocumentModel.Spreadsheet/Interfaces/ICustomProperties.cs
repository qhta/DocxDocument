namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Properties.
/// </summary>
public interface ICustomProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICustomProperty>? CustomProperties { get ; set; }
  
}
