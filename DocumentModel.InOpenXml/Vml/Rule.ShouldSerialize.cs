namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Rule
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeHow() => How is not null;
  public bool ShouldSerializeShapeReference() => !String.IsNullOrEmpty(ShapeReference);
  public bool ShouldSerializeProxies() => Proxies is not null;
}
