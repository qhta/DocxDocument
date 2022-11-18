namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorkbookProperties Class.
/// </summary>
public interface IWorkbookProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Date 1904
  /// </summary>
  public bool? Date1904 { get ; set; }
  
  /// <summary>
  /// dateCompatibility, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DateCompatibility { get ; set; }
  
  /// <summary>
  /// Show Objects
  /// </summary>
  public ObjectDisplay? ShowObjects { get ; set; }
  
  /// <summary>
  /// Show Border Unselected Table
  /// </summary>
  public bool? ShowBorderUnselectedTables { get ; set; }
  
  /// <summary>
  /// Filter Privacy
  /// </summary>
  public bool? FilterPrivacy { get ; set; }
  
  /// <summary>
  /// Prompted Solutions
  /// </summary>
  public bool? PromptedSolutions { get ; set; }
  
  /// <summary>
  /// Show Ink Annotations
  /// </summary>
  public bool? ShowInkAnnotation { get ; set; }
  
  /// <summary>
  /// Create Backup File
  /// </summary>
  public bool? BackupFile { get ; set; }
  
  /// <summary>
  /// Save External Link Values
  /// </summary>
  public bool? SaveExternalLinkValues { get ; set; }
  
  /// <summary>
  /// Update Links Behavior
  /// </summary>
  public UpdateLinksBehavior? UpdateLinks { get ; set; }
  
  /// <summary>
  /// Code Name
  /// </summary>
  public string? CodeName { get ; set; }
  
  /// <summary>
  /// Hide Pivot Field List
  /// </summary>
  public bool? HidePivotFieldList { get ; set; }
  
  /// <summary>
  /// Show Pivot Chart Filter
  /// </summary>
  public bool? ShowPivotChartFilter { get ; set; }
  
  /// <summary>
  /// Allow Refresh Query
  /// </summary>
  public bool? AllowRefreshQuery { get ; set; }
  
  /// <summary>
  /// Publish Items
  /// </summary>
  public bool? PublishItems { get ; set; }
  
  /// <summary>
  /// Check Compatibility On Save
  /// </summary>
  public bool? CheckCompatibility { get ; set; }
  
  /// <summary>
  /// Auto Compress Pictures
  /// </summary>
  public bool? AutoCompressPictures { get ; set; }
  
  /// <summary>
  /// Refresh all Connections on Open
  /// </summary>
  public bool? RefreshAllConnections { get ; set; }
  
  /// <summary>
  /// Default Theme Version
  /// </summary>
  public uint? DefaultThemeVersion { get ; set; }
  
}
