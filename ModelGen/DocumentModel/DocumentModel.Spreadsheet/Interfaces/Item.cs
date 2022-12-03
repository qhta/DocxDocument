namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Field Item.
/// </summary>
public interface Item // : System.Boolean
{
  /// <summary>
  /// Item User Caption
  /// </summary>
  public String? ItemName { get ; set; }
  
  /// <summary>
  /// Item Type
  /// </summary>
  public ItemKind? ItemType { get ; set; }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Character
  /// </summary>
  public Boolean? HasStringVlue { get ; set; }
  
  /// <summary>
  /// Hide Details
  /// </summary>
  public Boolean? HideDetails { get ; set; }
  
  /// <summary>
  /// Calculated Member
  /// </summary>
  public Boolean? Calculated { get ; set; }
  
  /// <summary>
  /// Missing
  /// </summary>
  public Boolean? Missing { get ; set; }
  
  /// <summary>
  /// Child Items
  /// </summary>
  public Boolean? ChildItems { get ; set; }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Expanded
  /// </summary>
  public Boolean? Expanded { get ; set; }
  
  /// <summary>
  /// Drill Across Attributes
  /// </summary>
  public Boolean? DrillAcrossAttributes { get ; set; }
  
}
