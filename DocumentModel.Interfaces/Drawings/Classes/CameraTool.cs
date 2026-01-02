namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CameraTool Class.
/// </summary>
public class CameraTool: ModelElement
{
  /// <summary>
  ///   cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  public string? CellRange { get; set; }
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ShapeId { get; set; }
}