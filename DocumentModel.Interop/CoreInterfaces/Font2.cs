
namespace DocumentModel.Interop.Core;

public interface Font2: InteropObject
{
  MsoTriState Bold { get; set; }
  MsoTriState Italic { get; set; }
  MsoTextStrike Strike { get; set; }
  MsoTextCaps Caps { get; set; }
  MsoTriState AutorotateNumbers { get; set; }
  float BaselineOffset { get; set; }
  float Kerning { get; set; }
  float Size { get; set; }
  float Spacing { get; set; }
  MsoTextUnderlineType UnderlineStyle { get; set; }
  MsoTriState Allcaps { get; set; }
  MsoTriState DoubleStrikeThrough { get; set; }
  MsoTriState Equalize { get; set; }
  FillFormat Fill { get; }
  GlowFormat Glow { get; }
  ReflectionFormat Reflection { get; }
  LineFormat Line { get; }
  ShadowFormat Shadow { get; }
  ColorFormat Highlight { get; }
  ColorFormat UnderlineColor { get; }
  MsoTriState Smallcaps { get; set; }
  MsoSoftEdgeType SoftEdgeFormat { get; set; }
  MsoTriState StrikeThrough { get; set; }
  MsoTriState Subscript { get; set; }
  MsoTriState Superscript { get; set; }
  MsoPresetTextEffect WordArtformat { get; set; }
  MsoTriState Embeddable { get; }
  MsoTriState Embedded { get; }
  string Name { get; set; }
  string NameAscii { get; set; }
  string NameComplexScript { get; set; }
  string NameFarEast { get; set; }
  string NameOther { get; set; }
}