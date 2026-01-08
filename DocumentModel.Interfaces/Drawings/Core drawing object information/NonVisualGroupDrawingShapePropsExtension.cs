namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension interface.
/// </summary>
public interface NonVisualGroupDrawingShapePropsExtension: Extension
{
  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
}