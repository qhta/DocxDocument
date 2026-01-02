namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public class NonVisualGroupDrawingShapePropsExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
}