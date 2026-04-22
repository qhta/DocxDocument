namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AudioCDTimeType
{
  public bool ShouldSerializeTrack() => Track is not null;
  public bool ShouldSerializeTime() => Time is not null;
}
