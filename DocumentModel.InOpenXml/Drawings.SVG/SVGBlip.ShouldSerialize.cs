namespace DocumentModel.Drawings.SVG;

public partial class SVGBlip
{
  public bool ShouldSerializeEmbed() => Embed is not null;
  public bool ShouldSerializeLink() => Link is not null;
}
