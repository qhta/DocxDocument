namespace DocumentModel.Drawings;

public partial class WebVideoProperty
{
  public bool ShouldSerializeEmbeddedHtml() => EmbeddedHtml is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeWidth() => Width is not null;
}
