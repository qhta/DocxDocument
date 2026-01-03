namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension interface.
/// </summary>
public interface NonVisualGroupDrawingShapePropsExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
}