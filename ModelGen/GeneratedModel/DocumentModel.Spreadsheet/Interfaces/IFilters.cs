namespace DocumentModel.Spreadsheet;

public interface IFilters // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Blank { get ; set; }
  
  public DocumentModel.Spreadsheet.Calendar? CalendarType { get ; set; }
  
}
