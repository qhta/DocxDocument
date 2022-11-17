namespace DocumentModel.Spreadsheet;

public interface IWorkbookProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? Date1904 { get ; set; }
  
  public bool? DateCompatibility { get ; set; }
  
  public ObjectDisplay? ShowObjects { get ; set; }
  
  public bool? ShowBorderUnselectedTables { get ; set; }
  
  public bool? FilterPrivacy { get ; set; }
  
  public bool? PromptedSolutions { get ; set; }
  
  public bool? ShowInkAnnotation { get ; set; }
  
  public bool? BackupFile { get ; set; }
  
  public bool? SaveExternalLinkValues { get ; set; }
  
  public UpdateLinksBehavior? UpdateLinks { get ; set; }
  
  public string? CodeName { get ; set; }
  
  public bool? HidePivotFieldList { get ; set; }
  
  public bool? ShowPivotChartFilter { get ; set; }
  
  public bool? AllowRefreshQuery { get ; set; }
  
  public bool? PublishItems { get ; set; }
  
  public bool? CheckCompatibility { get ; set; }
  
  public bool? AutoCompressPictures { get ; set; }
  
  public bool? RefreshAllConnections { get ; set; }
  
  public uint? DefaultThemeVersion { get ; set; }
  
}
