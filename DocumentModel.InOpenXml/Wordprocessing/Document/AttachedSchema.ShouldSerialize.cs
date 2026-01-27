namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AttachedSchema
{
  public bool ShouldSerializeUri() => Uri is not null;
}
