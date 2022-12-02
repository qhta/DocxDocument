namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the QueryTableExtensionList Class.
/// </summary>
public interface IQueryTableExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IQueryTableExtension>? QueryTableExtensions { get ; set; }
  
}
