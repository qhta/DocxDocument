namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DifferentialType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IAlignment))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IProtection))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFill))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFont))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberingFormat))]
public interface IDifferentialType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Font Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IFont? Font { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Spreadsheet.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Spreadsheet.IFill? Fill { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public DocumentModel.Spreadsheet.IAlignment? Alignment { get ; set; }
  
  /// <summary>
  /// Border Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IBorder? Border { get ; set; }
  
  /// <summary>
  /// Protection Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IProtection? Protection { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
