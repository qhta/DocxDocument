namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class WordprocessingGroup
{
  public bool ShouldSerializeWordprocessingShape() => WordprocessingShape is not null;
  public bool ShouldSerializeGroupShape() => GroupShape is not null;
  public bool ShouldSerializeGraphicFrame() => GraphicFrame is not null;
  public bool ShouldSerializePicture() => Picture is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
