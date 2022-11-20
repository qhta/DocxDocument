namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Field Item.
/// </summary>
public class Item: IItem
{
  /// <summary>
  /// Item User Caption
  /// </summary>
  public string? ItemName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Item Type
  /// </summary>
  public ItemValues? ItemType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Character
  /// </summary>
  public bool? HasStringVlue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Details
  /// </summary>
  public bool? HideDetails
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calculated Member
  /// </summary>
  public bool? Calculated
  {
    get;
    set;
  }
  
  /// <summary>
  /// Missing
  /// </summary>
  public bool? Missing
  {
    get;
    set;
  }
  
  /// <summary>
  /// Child Items
  /// </summary>
  public bool? ChildItems
  {
    get;
    set;
  }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public uint? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Expanded
  /// </summary>
  public bool? Expanded
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drill Across Attributes
  /// </summary>
  public bool? DrillAcrossAttributes
  {
    get;
    set;
  }
  
}
