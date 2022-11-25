namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Selection.
/// </summary>
public interface IPivotSelection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pane
  /// </summary>
  public DocumentModel.Spreadsheet.PaneKind? Pane { get ; set; }
  
  /// <summary>
  /// Show Header
  /// </summary>
  public System.Boolean? ShowHeader { get ; set; }
  
  /// <summary>
  /// Label
  /// </summary>
  public System.Boolean? Label { get ; set; }
  
  /// <summary>
  /// Data Selection
  /// </summary>
  public System.Boolean? Data { get ; set; }
  
  /// <summary>
  /// Extendable
  /// </summary>
  public System.Boolean? Extendable { get ; set; }
  
  /// <summary>
  /// Selection Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.Spreadsheet.PivotTableAxisKind? Axis { get ; set; }
  
  /// <summary>
  /// Dimension
  /// </summary>
  public System.UInt32? Dimension { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public System.UInt32? Start { get ; set; }
  
  /// <summary>
  /// Minimum
  /// </summary>
  public System.UInt32? Min { get ; set; }
  
  /// <summary>
  /// Maximum
  /// </summary>
  public System.UInt32? Max { get ; set; }
  
  /// <summary>
  /// Active Row
  /// </summary>
  public System.UInt32? ActiveRow { get ; set; }
  
  /// <summary>
  /// Active Column
  /// </summary>
  public System.UInt32? ActiveColumn { get ; set; }
  
  /// <summary>
  /// Previous Row
  /// </summary>
  public System.UInt32? PreviousRow { get ; set; }
  
  /// <summary>
  /// Previous Column Selection
  /// </summary>
  public System.UInt32? PreviousColumn { get ; set; }
  
  /// <summary>
  /// Click Count
  /// </summary>
  public System.UInt32? Click { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Pivot Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
}
