namespace DocumentModel.Drawings.SVG;
#pragma warning disable CS1591
public partial class SVGBlip
{
  public bool ShouldSerializeEmbed() => Embed is not null;
  public bool ShouldSerializeLink() => Link is not null;
}
