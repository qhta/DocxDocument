namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ObjectAnchor Class.
/// </summary>
public interface IObjectAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// moveWithCells
  /// </summary>
  public System.Boolean? MoveWithCells { get ; set; }
  
  /// <summary>
  /// sizeWithCells
  /// </summary>
  public System.Boolean? SizeWithCells { get ; set; }
  
  /// <summary>
  /// z-order
  /// </summary>
  public System.UInt32? ZOrder { get ; set; }
  
  /// <summary>
  /// FromMarker.
  /// </summary>
  public DocumentModel.Spreadsheet.IFromMarker? FromMarker { get ; set; }
  
  /// <summary>
  /// ToMarker.
  /// </summary>
  public DocumentModel.Spreadsheet.IToMarker? ToMarker { get ; set; }
  
}
