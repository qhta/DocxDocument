namespace DocumentModel.Office2016.Excel;

public interface IDifferentialFormatType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Spreadsheet.IFont? Font { get ; set; }

  public DocumentModel.Spreadsheet.INumberingFormat? NumberingFormat { get ; set; }

  public DocumentModel.Spreadsheet.IFill? Fill { get ; set; }

  public DocumentModel.Spreadsheet.IAlignment? Alignment { get ; set; }

  public DocumentModel.Spreadsheet.IBorder? Border { get ; set; }

  public DocumentModel.Spreadsheet.IProtection? Protection { get ; set; }

  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }

}
