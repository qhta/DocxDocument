namespace DocumentModel.Drawings;

public partial class RunProperties
{
  public bool ShouldSerializeOutline() => Outline is not null;
  public bool ShouldSerializeFill() => Fill is not null;
  public bool ShouldSerializeEffectList() => EffectList is not null;
  public bool ShouldSerializeEffectDag() => EffectDag is not null;
  public bool ShouldSerializeHighlight() => Highlight is not null;
  public bool ShouldSerializeUnderlineFollowsText() => UnderlineFollowsText is not null;
  public bool ShouldSerializeUnderline() => Underline is not null;
  public bool ShouldSerializeUnderlineFillText() => UnderlineFillText is not null;
  public bool ShouldSerializeUnderlineFill() => UnderlineFill is not null;
  public bool ShouldSerializeLatinFont() => LatinFont is not null;
  public bool ShouldSerializeEastAsianFont() => EastAsianFont is not null;
  public bool ShouldSerializeComplexScriptFont() => ComplexScriptFont is not null;
  public bool ShouldSerializeSymbolFont() => SymbolFont is not null;
  public bool ShouldSerializeHyperlinkOnClick() => HyperlinkOnClick is not null;
  public bool ShouldSerializeHyperlinkOnMouseOver() => HyperlinkOnMouseOver is not null;
  public bool ShouldSerializeRightToLeft() => RightToLeft is not null;
  public bool ShouldSerializeDrawingProperties() => DrawingProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
