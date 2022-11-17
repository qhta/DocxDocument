namespace DocumentModel.Spreadsheet;

public interface IPageSetup // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? PaperSize { get ; set; }

  public uint? Scale { get ; set; }

  public uint? FirstPageNumber { get ; set; }

  public uint? FitToWidth { get ; set; }

  public uint? FitToHeight { get ; set; }

  public PageOrder? PageOrder { get ; set; }

  public DocumentModel.Spreadsheet.Orientation? Orientation { get ; set; }

  public bool? UsePrinterDefaults { get ; set; }

  public bool? BlackAndWhite { get ; set; }

  public bool? Draft { get ; set; }

  public CellComments? CellComments { get ; set; }

  public bool? UseFirstPageNumber { get ; set; }

  public PrintError? Errors { get ; set; }

  public uint? HorizontalDpi { get ; set; }

  public uint? VerticalDpi { get ; set; }

  public uint? Copies { get ; set; }

  public string? Id { get ; set; }

}
