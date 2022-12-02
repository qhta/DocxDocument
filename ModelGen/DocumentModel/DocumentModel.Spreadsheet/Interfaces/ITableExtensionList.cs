namespace DocumentModel.Spreadsheet;

/// <summary>
/// Future Feature Data Storage Area.
/// </summary>
public interface ITableExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITableExtension>? TableExtensions { get ; set; }
  
}
