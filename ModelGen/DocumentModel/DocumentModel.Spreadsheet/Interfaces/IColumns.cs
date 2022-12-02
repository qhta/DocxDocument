namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column Information.
/// </summary>
public interface IColumns // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IColumn>? Columns { get ; set; }
  
}
