namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CameraTool interface.
/// </summary>
public interface CameraTool: IModelElement
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