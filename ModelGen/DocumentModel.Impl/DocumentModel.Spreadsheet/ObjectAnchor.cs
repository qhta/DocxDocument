namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ObjectAnchor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFromMarker))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IToMarker))]
public class ObjectAnchor: IObjectAnchor
{
  /// <summary>
  /// moveWithCells
  /// </summary>
  public bool? MoveWithCells
  {
    get;
    set;
  }
  
  /// <summary>
  /// sizeWithCells
  /// </summary>
  public bool? SizeWithCells
  {
    get;
    set;
  }
  
  /// <summary>
  /// z-order
  /// </summary>
  public uint? ZOrder
  {
    get;
    set;
  }
  
  /// <summary>
  /// FromMarker.
  /// </summary>
  public DocumentModel.Spreadsheet.IFromMarker? FromMarker
  {
    get;
    set;
  }
  
  /// <summary>
  /// ToMarker.
  /// </summary>
  public DocumentModel.Spreadsheet.IToMarker? ToMarker
  {
    get;
    set;
  }
  
}
