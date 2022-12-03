namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Properties.
/// </summary>
public interface SheetProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Synch Horizontal
  /// </summary>
  public Boolean? SyncHorizontal { get ; set; }
  
  /// <summary>
  /// Synch Vertical
  /// </summary>
  public Boolean? SyncVertical { get ; set; }
  
  /// <summary>
  /// Synch Reference
  /// </summary>
  public String? SyncReference { get ; set; }
  
  /// <summary>
  /// Transition Formula Evaluation
  /// </summary>
  public Boolean? TransitionEvaluation { get ; set; }
  
  /// <summary>
  /// Transition Formula Entry
  /// </summary>
  public Boolean? TransitionEntry { get ; set; }
  
  /// <summary>
  /// Published
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Code Name
  /// </summary>
  public String? CodeName { get ; set; }
  
  /// <summary>
  /// Filter Mode
  /// </summary>
  public Boolean? FilterMode { get ; set; }
  
  /// <summary>
  /// Enable Conditional Formatting Calculations
  /// </summary>
  public Boolean? EnableFormatConditionsCalculation { get ; set; }
  
  /// <summary>
  /// Sheet Tab Color.
  /// </summary>
  public ColorType? TabColor { get ; set; }
  
  /// <summary>
  /// Outline Properties.
  /// </summary>
  public OutlineProperties? OutlineProperties { get ; set; }
  
  /// <summary>
  /// Page Setup Properties.
  /// </summary>
  public PageSetupProperties? PageSetupProperties { get ; set; }
  
}
