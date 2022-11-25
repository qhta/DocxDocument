namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query Table.
/// </summary>
public interface IQueryTable // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// headers
  /// </summary>
  public System.Boolean? Headers { get ; set; }
  
  /// <summary>
  /// rowNumbers
  /// </summary>
  public System.Boolean? RowNumbers { get ; set; }
  
  /// <summary>
  /// disableRefresh
  /// </summary>
  public System.Boolean? DisableRefresh { get ; set; }
  
  /// <summary>
  /// backgroundRefresh
  /// </summary>
  public System.Boolean? BackgroundRefresh { get ; set; }
  
  /// <summary>
  /// firstBackgroundRefresh
  /// </summary>
  public System.Boolean? FirstBackgroundRefresh { get ; set; }
  
  /// <summary>
  /// refreshOnLoad
  /// </summary>
  public System.Boolean? RefreshOnLoad { get ; set; }
  
  /// <summary>
  /// growShrinkType
  /// </summary>
  public DocumentModel.Spreadsheet.GrowShrinkKind? GrowShrinkType { get ; set; }
  
  /// <summary>
  /// fillFormulas
  /// </summary>
  public System.Boolean? FillFormulas { get ; set; }
  
  /// <summary>
  /// removeDataOnSave
  /// </summary>
  public System.Boolean? RemoveDataOnSave { get ; set; }
  
  /// <summary>
  /// disableEdit
  /// </summary>
  public System.Boolean? DisableEdit { get ; set; }
  
  /// <summary>
  /// preserveFormatting
  /// </summary>
  public System.Boolean? PreserveFormatting { get ; set; }
  
  /// <summary>
  /// adjustColumnWidth
  /// </summary>
  public System.Boolean? AdjustColumnWidth { get ; set; }
  
  /// <summary>
  /// intermediate
  /// </summary>
  public System.Boolean? Intermediate { get ; set; }
  
  /// <summary>
  /// connectionId
  /// </summary>
  public System.UInt32? ConnectionId { get ; set; }
  
  /// <summary>
  /// Auto Format Id
  /// </summary>
  public System.UInt32? AutoFormatId { get ; set; }
  
  /// <summary>
  /// Apply Number Formats
  /// </summary>
  public System.Boolean? ApplyNumberFormats { get ; set; }
  
  /// <summary>
  /// Apply Border Formats
  /// </summary>
  public System.Boolean? ApplyBorderFormats { get ; set; }
  
  /// <summary>
  /// Apply Font Formats
  /// </summary>
  public System.Boolean? ApplyFontFormats { get ; set; }
  
  /// <summary>
  /// Apply Pattern Formats
  /// </summary>
  public System.Boolean? ApplyPatternFormats { get ; set; }
  
  /// <summary>
  /// Apply Alignment Formats
  /// </summary>
  public System.Boolean? ApplyAlignmentFormats { get ; set; }
  
  /// <summary>
  /// Apply Width / Height Formats
  /// </summary>
  public System.Boolean? ApplyWidthHeightFormats { get ; set; }
  
  /// <summary>
  /// QueryTableRefresh.
  /// </summary>
  public DocumentModel.Spreadsheet.IQueryTableRefresh? QueryTableRefresh { get ; set; }
  
  /// <summary>
  /// QueryTableExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? QueryTableExtensionList { get ; set; }
  
}
