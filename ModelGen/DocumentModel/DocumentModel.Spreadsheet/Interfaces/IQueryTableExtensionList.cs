namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtensionList Class.
/// </summary>
public interface IQueryTableExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IQueryTableExtension>? QueryTableExtensions { get ; set; }
  
}
