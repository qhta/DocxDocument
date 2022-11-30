namespace DocumentModel.Spreadsheet;

/// <summary>
/// Single Cells.
/// </summary>
public interface ISingleXmlCells // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ISingleXmlCell>? SingleXmlCells { get ; set; }
  
}
