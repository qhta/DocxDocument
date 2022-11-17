namespace DocumentModel.Spreadsheet;

public interface IWebQueryProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? XmlSource { get ; set; }

  public bool? SourceData { get ; set; }

  public bool? ParsePreTag { get ; set; }

  public bool? Consecutive { get ; set; }

  public bool? FirstRow { get ; set; }

  public bool? CreatedInExcel97 { get ; set; }

  public bool? TextDates { get ; set; }

  public bool? RefreshedInExcel2000 { get ; set; }

  public string? Url { get ; set; }

  public string? Post { get ; set; }

  public bool? HtmlTables { get ; set; }

  public HtmlFormatting? HtmlFormat { get ; set; }

  public string? EditPage { get ; set; }

  public ITables? Tables { get ; set; }

}
