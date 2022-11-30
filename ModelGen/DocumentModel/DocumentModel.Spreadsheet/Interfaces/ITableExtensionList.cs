namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Feature Data Storage Area.
/// </summary>
public interface ITableExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITableExtension>? TableExtensions { get ; set; }
  
}
