namespace DocumentModel.Wordprocessing;

public partial class AttachedSchema
{
  public bool ShouldSerializeUri() => Uri is not null;
}
