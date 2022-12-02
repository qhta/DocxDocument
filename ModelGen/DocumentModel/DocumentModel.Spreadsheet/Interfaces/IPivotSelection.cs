namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Selection.
/// </summary>
public interface IPivotSelection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pane
  /// </summary>
  public PaneKind? Pane { get ; set; }
  
  /// <summary>
  /// Show Header
  /// </summary>
  public Boolean? ShowHeader { get ; set; }
  
  /// <summary>
  /// Label
  /// </summary>
  public Boolean? Label { get ; set; }
  
  /// <summary>
  /// Data Selection
  /// </summary>
  public Boolean? Data { get ; set; }
  
  /// <summary>
  /// Extendable
  /// </summary>
  public Boolean? Extendable { get ; set; }
  
  /// <summary>
  /// Selection Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public PivotTableAxisKind? Axis { get ; set; }
  
  /// <summary>
  /// Dimension
  /// </summary>
  public UInt32? Dimension { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public UInt32? Start { get ; set; }
  
  /// <summary>
  /// Minimum
  /// </summary>
  public UInt32? Min { get ; set; }
  
  /// <summary>
  /// Maximum
  /// </summary>
  public UInt32? Max { get ; set; }
  
  /// <summary>
  /// Active Row
  /// </summary>
  public UInt32? ActiveRow { get ; set; }
  
  /// <summary>
  /// Active Column
  /// </summary>
  public UInt32? ActiveColumn { get ; set; }
  
  /// <summary>
  /// Previous Row
  /// </summary>
  public UInt32? PreviousRow { get ; set; }
  
  /// <summary>
  /// Previous Column Selection
  /// </summary>
  public UInt32? PreviousColumn { get ; set; }
  
  /// <summary>
  /// Click Count
  /// </summary>
  public UInt32? Click { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Pivot Area.
  /// </summary>
  public IPivotArea? PivotArea { get ; set; }
  
}
