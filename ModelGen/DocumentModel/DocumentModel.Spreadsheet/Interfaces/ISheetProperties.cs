namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Properties.
/// </summary>
public interface ISheetProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Synch Horizontal
  /// </summary>
  public System.Boolean? SyncHorizontal { get ; set; }
  
  /// <summary>
  /// Synch Vertical
  /// </summary>
  public System.Boolean? SyncVertical { get ; set; }
  
  /// <summary>
  /// Synch Reference
  /// </summary>
  public System.String? SyncReference { get ; set; }
  
  /// <summary>
  /// Transition Formula Evaluation
  /// </summary>
  public System.Boolean? TransitionEvaluation { get ; set; }
  
  /// <summary>
  /// Transition Formula Entry
  /// </summary>
  public System.Boolean? TransitionEntry { get ; set; }
  
  /// <summary>
  /// Published
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Code Name
  /// </summary>
  public System.String? CodeName { get ; set; }
  
  /// <summary>
  /// Filter Mode
  /// </summary>
  public System.Boolean? FilterMode { get ; set; }
  
  /// <summary>
  /// Enable Conditional Formatting Calculations
  /// </summary>
  public System.Boolean? EnableFormatConditionsCalculation { get ; set; }
  
  /// <summary>
  /// Sheet Tab Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColorType? TabColor { get ; set; }
  
  /// <summary>
  /// Outline Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IOutlineProperties? OutlineProperties { get ; set; }
  
  /// <summary>
  /// Page Setup Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IPageSetupProperties? PageSetupProperties { get ; set; }
  
}
