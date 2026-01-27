namespace DocumentModel.Drawings;

public partial class NonVisualGraphicFrameProperties<T>
{
  public bool ShouldSerializeGraphicFrameLocks() => GraphicFrameLocks is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
