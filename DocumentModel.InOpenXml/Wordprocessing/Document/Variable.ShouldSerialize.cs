namespace DocumentModel.Wordprocessing;

public partial class Variable
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeVal() => Val is not null;
}
