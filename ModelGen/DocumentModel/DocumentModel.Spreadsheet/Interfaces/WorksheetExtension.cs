namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtension Class.
/// </summary>
public interface WorksheetExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ConditionalFormattings? ConditionalFormattings { get ; set; }
  
  public DataValidations? DataValidations { get ; set; }
  
  public SparklineGroups? SparklineGroups { get ; set; }
  
  public SlicerList? SlicerList { get ; set; }
  
  public ProtectedRanges? ProtectedRanges { get ; set; }
  
  public IgnoredErrors? IgnoredErrors { get ; set; }
  
  public TimelineReferences? TimelineReferences { get ; set; }
  
}
