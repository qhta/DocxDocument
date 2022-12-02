namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtension Class.
/// </summary>
public interface IWorksheetExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IConditionalFormattings? ConditionalFormattings { get ; set; }
  
  public IDataValidations? DataValidations { get ; set; }
  
  public ISparklineGroups? SparklineGroups { get ; set; }
  
  public ISlicerList? SlicerList { get ; set; }
  
  public IProtectedRanges? ProtectedRanges { get ; set; }
  
  public IIgnoredErrors? IgnoredErrors { get ; set; }
  
  public ITimelineReferences? TimelineReferences { get ; set; }
  
}
