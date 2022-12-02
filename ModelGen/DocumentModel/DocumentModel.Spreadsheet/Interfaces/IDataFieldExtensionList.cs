namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFieldExtensionList Class.
/// </summary>
public interface IDataFieldExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDataFieldExtension>? DataFieldExtensions { get ; set; }
  
}
