namespace DocumentModel.Office2019.Excel.RichData;

public interface IRichValueFallback // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  public RichValueFallbackType? T { get ; set; }

  public string? Text { get ; set; }

}
