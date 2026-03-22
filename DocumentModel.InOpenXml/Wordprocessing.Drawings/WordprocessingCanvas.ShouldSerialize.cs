namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class WordprocessingCanvas
{
  public bool ShouldSerializeBackgroundFormatting() => BackgroundFormatting is not null;
  public bool ShouldSerializeWholeFormatting() => WholeFormatting is not null;
  public bool ShouldSerializeWordprocessingShape() => WordprocessingShape is not null;
  public bool ShouldSerializePicture() => Picture is not null;
  public bool ShouldSerializeWordprocessingGroup() => WordprocessingGroup is not null;
  public bool ShouldSerializeGraphicFrameType() => GraphicFrameType is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
