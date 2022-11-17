namespace DocumentModel.Office2013.Excel;

public interface ISurveyPrSurveyElementPr // : DocumentFormat.OpenXml.Office2013.Excel.OpenXmlSurveyElementPrElement
{
  public string? CssClass { get ; set; }

  public int? Bottom { get ; set; }

  public int? Top { get ; set; }

  public int? Left { get ; set; }

  public int? Right { get ; set; }

  public uint? Width { get ; set; }

  public uint? Height { get ; set; }

  public SurveyPosition? Position { get ; set; }

  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList { get ; set; }

}
