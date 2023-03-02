namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public record NonVisualGroupDrawingShapePropsExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
}