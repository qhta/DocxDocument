namespace DocumentModel.Drawings;

public partial class AudioCDTimeType
{
  public bool ShouldSerializeTrack() => Track is not null;
  public bool ShouldSerializeTime() => Time is not null;
}
