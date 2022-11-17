namespace DocumentModel.Spreadsheet;

public interface IPatternFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public Pattern? PatternType { get ; set; }
  
  public DocumentModel.Spreadsheet.IForegroundColor? ForegroundColor { get ; set; }
  
  public DocumentModel.Spreadsheet.IBackgroundColor? BackgroundColor { get ; set; }
  
}
