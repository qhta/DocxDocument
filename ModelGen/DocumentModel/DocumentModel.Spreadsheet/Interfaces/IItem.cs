namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Field Item.
/// </summary>
public interface IItem // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Item User Caption
  /// </summary>
  public System.String? ItemName { get ; set; }
  
  /// <summary>
  /// Item Type
  /// </summary>
  public DocumentModel.Spreadsheet.ItemKind? ItemType { get ; set; }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Character
  /// </summary>
  public System.Boolean? HasStringVlue { get ; set; }
  
  /// <summary>
  /// Hide Details
  /// </summary>
  public System.Boolean? HideDetails { get ; set; }
  
  /// <summary>
  /// Calculated Member
  /// </summary>
  public System.Boolean? Calculated { get ; set; }
  
  /// <summary>
  /// Missing
  /// </summary>
  public System.Boolean? Missing { get ; set; }
  
  /// <summary>
  /// Child Items
  /// </summary>
  public System.Boolean? ChildItems { get ; set; }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Expanded
  /// </summary>
  public System.Boolean? Expanded { get ; set; }
  
  /// <summary>
  /// Drill Across Attributes
  /// </summary>
  public System.Boolean? DrillAcrossAttributes { get ; set; }
  
}
