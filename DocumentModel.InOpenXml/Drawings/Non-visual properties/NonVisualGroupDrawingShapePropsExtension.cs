namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension interface.
/// </summary>
public partial class NonVisualGroupDrawingShapePropsExtension : ModelElement<DXD.NonVisualGroupDrawingShapePropsExtension>, IExtension
{
  public NonVisualGroupProperties? NonVisualGroupProperties { get; set; }
  public string? UriString { get; set; }
}