namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AttachedSchema
{
  public bool ShouldSerializeUri() => !String.IsNullOrEmpty(Uri);
}
