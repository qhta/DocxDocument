namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Properties.
/// </summary>
public interface ICustomProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICustomProperty>? CustomProperties { get ; set; }
  
}
