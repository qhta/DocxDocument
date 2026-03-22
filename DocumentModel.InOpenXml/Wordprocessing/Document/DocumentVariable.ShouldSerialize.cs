namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DocumentVariable
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeVal() => Value is not null;
}
