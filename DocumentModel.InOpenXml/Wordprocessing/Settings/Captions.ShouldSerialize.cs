namespace DocumentModel.Wordprocessing;

public partial class Captions
{
  public bool ShouldSerializeCaptionDefinitions() => CaptionDefinitions is not null;
  public bool ShouldSerializeAutoCaptions() => AutoCaptions is not null;
}
