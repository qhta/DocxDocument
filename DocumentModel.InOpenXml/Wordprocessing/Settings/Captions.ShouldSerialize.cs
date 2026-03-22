namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Captions
{
  public bool ShouldSerializeCaptionDefinitions() => CaptionDefinitions is not null;
  public bool ShouldSerializeAutoCaptions() => AutoCaptions is not null;
}
