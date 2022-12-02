namespace DocumentModel.Spreadsheet;

/// <summary>
/// Single Cells.
/// </summary>
public interface ISingleXmlCells // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<ISingleXmlCell>? SingleXmlCells { get ; set; }
  
}
