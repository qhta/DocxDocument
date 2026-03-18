namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ExternalData
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeAutoUpdate() => AutoUpdate is not null;
}
