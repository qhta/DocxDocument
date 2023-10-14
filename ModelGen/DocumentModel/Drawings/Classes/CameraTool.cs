namespace DocumentModel.Drawings;


/// <summary>
///   Defines the CameraTool Class.
/// </summary>
public partial class CameraTool
{
  
  /// <summary>
  ///   cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  public String? CellRange { get; set; }
  
  
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ShapeId { get; set; }
  
}
