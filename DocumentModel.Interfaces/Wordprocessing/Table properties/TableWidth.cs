namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableWidth interface. Its Value can be absolute (in twips) or relative (in fiftieth of percent), or "auto" or "nil".
///   The type of the Value is determined with the Type property.
///   This interface is used in multiple measures according to table horizontal dimension.
/// </summary>
public interface TableWidth : IModelElement
{
  /// <summary>
  ///   Table Width value. Can be absolute (in twips) or relative (in fiftieth of percent).
  /// </summary>
  public Int64 Value { get; set; }
  /// <summary>
  ///   Table Width 
  /// </summary>
  public TableWidthUnitType? Type { get; set; }
}