namespace DocumentModel.Spreadsheet;

public interface IPageSetupProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? AutoPageBreaks { get ; set; }
  
  public bool? FitToPage { get ; set; }
  
}
