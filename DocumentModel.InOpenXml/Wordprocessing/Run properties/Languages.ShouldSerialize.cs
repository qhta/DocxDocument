namespace DocumentModel.Wordprocessing;

public partial class Languages
{
  public bool ShouldSerializeRegular() => Regular is not null;
  public bool ShouldSerializeComplexScript() => ComplexScript is not null;
  public bool ShouldSerializeEastAsia() => EastAsia is not null;
}
