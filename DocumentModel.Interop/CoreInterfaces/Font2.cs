
namespace DocumentModel.Interop.Core;

public partial interface Font2: InteropObject
{
  public MsoTriState Bold { get; set; }
  public MsoTriState Italic { get; set; }
  public MsoTextStrike Strike { get; set; }
  public MsoTextCaps Caps { get; set; }
  public MsoTriState AutorotateNumbers { get; set; }
  public float BaselineOffset { get; set; }
  public float Kerning { get; set; }
  public float Size { get; set; }
  public float Spacing { get; set; }
  public MsoTextUnderlineType UnderlineStyle { get; set; }
  public MsoTriState Allcaps { get; set; }
  public MsoTriState DoubleStrikeThrough { get; set; }
  public MsoTriState Equalize { get; set; }
  public FillFormat Fill { get; }
  public GlowFormat Glow { get; }
  public ReflectionFormat Reflection { get; }
  public LineFormat Line { get; }
  public ShadowFormat Shadow { get; }
  public ColorFormat Highlight { get; }
  public ColorFormat UnderlineColor { get; }
  public MsoTriState Smallcaps { get; set; }
  public MsoSoftEdgeType SoftEdgeFormat { get; set; }
  public MsoTriState StrikeThrough { get; set; }
  public MsoTriState Subscript { get; set; }
  public MsoTriState Superscript { get; set; }
  public MsoPresetTextEffect WordArtformat { get; set; }
  public MsoTriState Embeddable { get; }
  public MsoTriState Embedded { get; }
  public string Name { get; set; }
  public string NameAscii { get; set; }
  public string NameComplexScript { get; set; }
  public string NameFarEast { get; set; }
  public string NameOther { get; set; }
}
