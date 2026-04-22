namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class LineNumberType
{
  public bool ShouldSerializeCountBy() => CountBy is not null;
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeDistance() => !String.IsNullOrEmpty(Distance);
  public bool ShouldSerializeRestart() => Restart is not null;
}
