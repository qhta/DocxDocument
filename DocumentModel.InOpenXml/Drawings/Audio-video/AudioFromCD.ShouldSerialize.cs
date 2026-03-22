namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class AudioFromCD
{
  public bool ShouldSerializeStartTime() => StartTime is not null;
  public bool ShouldSerializeEndTime() => EndTime is not null;
}
