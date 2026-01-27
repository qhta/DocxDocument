namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Languages
{
  public bool ShouldSerializeRegular() => Regular is not null;
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeEastAsia() => EastAsia is not null;
}
