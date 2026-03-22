namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class RelationTable
{
  public bool ShouldSerializeRelations() => Relations is not null;
  public bool ShouldSerializeExtension() => Extension is not null;
}
