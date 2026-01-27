namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class NonVisualGraphicFrameProperties<T>
{
  public bool ShouldSerializeGraphicFrameLocks() => GraphicFrameLocks is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
