namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtensionList interface.
/// </summary>
public interface NonVisualGroupDrawingShapePropsExtensionList: IModelElement
{
  public Collection<NonVisualGroupDrawingShapePropsExtension>? NonVisualGroupDrawingShapePropsExtensions { get; set; }
}