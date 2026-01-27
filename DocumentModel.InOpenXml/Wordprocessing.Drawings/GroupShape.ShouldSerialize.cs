namespace DocumentModel.Wordprocessing.Drawings;

public partial class GroupShape
{
 public bool ShouldSerializeWordprocessingShape() => WordprocessingShape is not null;
  public bool ShouldSerializeChildGroupShape() => ChildGroupShape is not null;
  public bool ShouldSerializeGraphicFrame() => GraphicFrame is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
