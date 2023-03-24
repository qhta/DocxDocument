namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CameraTool Class.
/// </summary>
public class CameraTool: ModelElement
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