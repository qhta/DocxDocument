namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotArea Class.
/// </summary>
public interface IPivotArea // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public System.Int32? Field { get ; set; }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public DocumentModel.Spreadsheet.PivotAreaKind? Type { get ; set; }
  
  /// <summary>
  /// Data Only
  /// </summary>
  public System.Boolean? DataOnly { get ; set; }
  
  /// <summary>
  /// Labels Only
  /// </summary>
  public System.Boolean? LabelOnly { get ; set; }
  
  /// <summary>
  /// Include Row Grand Total
  /// </summary>
  public System.Boolean? GrandRow { get ; set; }
  
  /// <summary>
  /// Include Column Grand Total
  /// </summary>
  public System.Boolean? GrandColumn { get ; set; }
  
  /// <summary>
  /// Cache Index
  /// </summary>
  public System.Boolean? CacheIndex { get ; set; }
  
  /// <summary>
  /// Outline
  /// </summary>
  public System.Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Offset Reference
  /// </summary>
  public System.String? Offset { get ; set; }
  
  /// <summary>
  /// Collapsed Levels Are Subtotals
  /// </summary>
  public System.Boolean? CollapsedLevelsAreSubtotals { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.Spreadsheet.PivotTableAxisKind? Axis { get ; set; }
  
  /// <summary>
  /// Field Position
  /// </summary>
  public System.UInt32? FieldPosition { get ; set; }
  
  /// <summary>
  /// References.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotAreaReferences? PivotAreaReferences { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
