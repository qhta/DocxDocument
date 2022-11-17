namespace DocumentModel.Spreadsheet;

public interface IPivotArea // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Field { get ; set; }
  
  public PivotArea? Type { get ; set; }
  
  public bool? DataOnly { get ; set; }
  
  public bool? LabelOnly { get ; set; }
  
  public bool? GrandRow { get ; set; }
  
  public bool? GrandColumn { get ; set; }
  
  public bool? CacheIndex { get ; set; }
  
  public bool? Outline { get ; set; }
  
  public string? Offset { get ; set; }
  
  public bool? CollapsedLevelsAreSubtotals { get ; set; }
  
  public PivotTableAxis? Axis { get ; set; }
  
  public uint? FieldPosition { get ; set; }
  
  public IPivotAreaReferences? PivotAreaReferences { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
