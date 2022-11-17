namespace DocumentModel.Spreadsheet;

public interface IChartSheetPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? PaperSize { get ; set; }

  public uint? FirstPageNumber { get ; set; }

  public DocumentModel.Spreadsheet.Orientation? Orientation { get ; set; }

  public bool? UsePrinterDefaults { get ; set; }

  public bool? BlackAndWhite { get ; set; }

  public bool? Draft { get ; set; }

  public bool? UseFirstPageNumber { get ; set; }

  public uint? HorizontalDpi { get ; set; }

  public uint? VerticalDpi { get ; set; }

  public uint? Copies { get ; set; }

  public string? Id { get ; set; }

}
