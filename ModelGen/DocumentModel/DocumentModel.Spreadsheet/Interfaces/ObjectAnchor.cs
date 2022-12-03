namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ObjectAnchor Class.
/// </summary>
public interface ObjectAnchor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// moveWithCells
  /// </summary>
  public Boolean? MoveWithCells { get ; set; }
  
  /// <summary>
  /// sizeWithCells
  /// </summary>
  public Boolean? SizeWithCells { get ; set; }
  
  /// <summary>
  /// z-order
  /// </summary>
  public UInt32? ZOrder { get ; set; }
  
  /// <summary>
  /// FromMarker.
  /// </summary>
  public FromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// ToMarker.
  /// </summary>
  public ToMarker? ToMarker { get ; set; }
  
}
