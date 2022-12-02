namespace DocumentModel.Spreadsheet;

/// <summary>
/// Authors.
/// </summary>
public interface IAuthors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IXstringType>? Authors { get ; set; }
  
}
