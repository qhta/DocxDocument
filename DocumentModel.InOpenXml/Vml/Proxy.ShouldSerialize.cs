namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Proxy
{
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeEnd() => End is not null;
  public bool ShouldSerializeShapeReference() => ShapeReference is not null;
  public bool ShouldSerializeConnectionLocation() => ConnectionLocation is not null;
}
