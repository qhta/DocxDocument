namespace DocumentModel.Office2010.Excel;

public interface IPivotEditValue // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  public PivotEditValueType? ValueType { get ; set; }

  public string? Text { get ; set; }

}
