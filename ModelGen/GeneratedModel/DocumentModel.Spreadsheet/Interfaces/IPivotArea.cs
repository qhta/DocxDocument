namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Item Location.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotAreaReferences))]
public interface IPivotArea // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public int? Field { get ; set; }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public PivotArea? Type { get ; set; }
  
  /// <summary>
  /// Data Only
  /// </summary>
  public bool? DataOnly { get ; set; }
  
  /// <summary>
  /// Labels Only
  /// </summary>
  public bool? LabelOnly { get ; set; }
  
  /// <summary>
  /// Include Row Grand Total
  /// </summary>
  public bool? GrandRow { get ; set; }
  
  /// <summary>
  /// Include Column Grand Total
  /// </summary>
  public bool? GrandColumn { get ; set; }
  
  /// <summary>
  /// Cache Index
  /// </summary>
  public bool? CacheIndex { get ; set; }
  
  /// <summary>
  /// Outline
  /// </summary>
  public bool? Outline { get ; set; }
  
  /// <summary>
  /// Offset Reference
  /// </summary>
  public string? Offset { get ; set; }
  
  /// <summary>
  /// Collapsed Levels Are Subtotals
  /// </summary>
  public bool? CollapsedLevelsAreSubtotals { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public PivotTableAxis? Axis { get ; set; }
  
  /// <summary>
  /// Field Position
  /// </summary>
  public uint? FieldPosition { get ; set; }
  
  /// <summary>
  /// References.
  /// </summary>
  public IPivotAreaReferences? PivotAreaReferences { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
