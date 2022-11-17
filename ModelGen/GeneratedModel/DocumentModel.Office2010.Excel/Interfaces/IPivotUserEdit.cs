namespace DocumentModel.Office2010.Excel;

public interface IPivotUserEdit // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office.Excel.IFormula? Formula { get ; set; }
  
  public IPivotEditValue? PivotEditValue { get ; set; }
  
}
