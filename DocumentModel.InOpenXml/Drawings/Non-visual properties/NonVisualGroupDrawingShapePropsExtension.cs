namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension interface.
/// </summary>
public interface NonVisualGroupDrawingShapePropsExtension: IExtension
{
  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
}