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
  
  public DocumentModel.Office2010.Excel.IConditionalFormattings? ConditionalFormattings { get ; set; }
  
  public DocumentModel.Office2010.Excel.IDataValidations? DataValidations { get ; set; }
  
  public DocumentModel.Office2010.Excel.ISparklineGroups? SparklineGroups { get ; set; }
  
  public DocumentModel.Office2010.Excel.ISlicerList? SlicerList { get ; set; }
  
  public DocumentModel.Office2010.Excel.IProtectedRanges? ProtectedRanges { get ; set; }
  
  public DocumentModel.Office2010.Excel.IIgnoredErrors? IgnoredErrors { get ; set; }
  
  public DocumentModel.Office2013.Excel.ITimelineReferences? TimelineReferences { get ; set; }
  
}
