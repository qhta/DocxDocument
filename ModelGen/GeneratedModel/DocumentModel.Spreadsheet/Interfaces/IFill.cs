namespace DocumentModel.Spreadsheet;

public interface IFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Spreadsheet.IPatternFill? PatternFill { get ; set; }

  public DocumentModel.Spreadsheet.IGradientFill? GradientFill { get ; set; }

}
