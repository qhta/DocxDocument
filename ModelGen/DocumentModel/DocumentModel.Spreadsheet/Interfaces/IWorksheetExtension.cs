namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtension Class.
/// </summary>
public interface IWorksheetExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.IConditionalFormattings? ConditionalFormattings { get ; set; }
  
  public DocumentModel.Spreadsheet.IDataValidations? DataValidations { get ; set; }
  
  public DocumentModel.Spreadsheet.ISparklineGroups? SparklineGroups { get ; set; }
  
  public DocumentModel.Spreadsheet.ISlicerList? SlicerList { get ; set; }
  
  public DocumentModel.Spreadsheet.IProtectedRanges? ProtectedRanges { get ; set; }
  
  public DocumentModel.Spreadsheet.IIgnoredErrors? IgnoredErrors { get ; set; }
  
  public DocumentModel.Spreadsheet.ITimelineReferences? TimelineReferences { get ; set; }
  
}
