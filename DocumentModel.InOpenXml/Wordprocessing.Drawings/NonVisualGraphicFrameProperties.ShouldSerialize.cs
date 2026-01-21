namespace DocumentModel.Wordprocessing.Drawings;

public partial class NonVisualGraphicFrameProperties
{
  public bool ShouldSerializeGraphicFrameLocks() => GraphicFrameLocks is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
