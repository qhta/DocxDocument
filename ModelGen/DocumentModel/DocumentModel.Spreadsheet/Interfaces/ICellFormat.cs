namespace DocumentModel.Spreadsheet;

/// <summary>
/// Formatting Elements.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IAlignment))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IProtection))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface ICellFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Number Format Id
  /// </summary>
  public uint? NumberFormatId { get ; set; }
  
  /// <summary>
  /// Font Id
  /// </summary>
  public uint? FontId { get ; set; }
  
  /// <summary>
  /// Fill Id
  /// </summary>
  public uint? FillId { get ; set; }
  
  /// <summary>
  /// Border Id
  /// </summary>
  public uint? BorderId { get ; set; }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public uint? FormatId { get ; set; }
  
  /// <summary>
  /// Quote Prefix
  /// </summary>
  public bool? QuotePrefix { get ; set; }
  
  /// <summary>
  /// Pivot Button
  /// </summary>
  public bool? PivotButton { get ; set; }
  
  /// <summary>
  /// Apply Number Format
  /// </summary>
  public bool? ApplyNumberFormat { get ; set; }
  
  /// <summary>
  /// Apply Font
  /// </summary>
  public bool? ApplyFont { get ; set; }
  
  /// <summary>
  /// Apply Fill
  /// </summary>
  public bool? ApplyFill { get ; set; }
  
  /// <summary>
  /// Apply Border
  /// </summary>
  public bool? ApplyBorder { get ; set; }
  
  /// <summary>
  /// Apply Alignment
  /// </summary>
  public bool? ApplyAlignment { get ; set; }
  
  /// <summary>
  /// Apply Protection
  /// </summary>
  public bool? ApplyProtection { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public DocumentModel.Spreadsheet.IAlignment? Alignment { get ; set; }
  
  /// <summary>
  /// Protection.
  /// </summary>
  public DocumentModel.Spreadsheet.IProtection? Protection { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
