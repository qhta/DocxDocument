namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class WebVideoProperty
{
  public bool ShouldSerializeEmbeddedHtml() => !String.IsNullOrEmpty(EmbeddedHtml);
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeWidth() => Width is not null;
}
