namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Rule
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeHow() => How is not null;
  public bool ShouldSerializeShapeReference() => ShapeReference is not null;
  public bool ShouldSerializeProxies() => Proxies is not null;
}
