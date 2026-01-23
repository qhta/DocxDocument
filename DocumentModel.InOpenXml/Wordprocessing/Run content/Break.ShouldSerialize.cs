namespace DocumentModel.Wordprocessing;

public partial class Break
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeClear() => Clear is not null;
}
