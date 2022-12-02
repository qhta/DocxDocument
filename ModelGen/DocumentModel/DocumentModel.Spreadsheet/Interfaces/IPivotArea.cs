namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotArea Class.
/// </summary>
public interface IPivotArea // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public Int32? Field { get ; set; }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public PivotAreaKind? Type { get ; set; }
  
  /// <summary>
  /// Data Only
  /// </summary>
  public Boolean? DataOnly { get ; set; }
  
  /// <summary>
  /// Labels Only
  /// </summary>
  public Boolean? LabelOnly { get ; set; }
  
  /// <summary>
  /// Include Row Grand Total
  /// </summary>
  public Boolean? GrandRow { get ; set; }
  
  /// <summary>
  /// Include Column Grand Total
  /// </summary>
  public Boolean? GrandColumn { get ; set; }
  
  /// <summary>
  /// Cache Index
  /// </summary>
  public Boolean? CacheIndex { get ; set; }
  
  /// <summary>
  /// Outline
  /// </summary>
  public Boolean? Outline { get ; set; }
  
  /// <summary>
  /// Offset Reference
  /// </summary>
  public String? Offset { get ; set; }
  
  /// <summary>
  /// Collapsed Levels Are Subtotals
  /// </summary>
  public Boolean? CollapsedLevelsAreSubtotals { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public PivotTableAxisKind? Axis { get ; set; }
  
  /// <summary>
  /// Field Position
  /// </summary>
  public UInt32? FieldPosition { get ; set; }
  
  /// <summary>
  /// References.
  /// </summary>
  public IPivotAreaReferences? PivotAreaReferences { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
