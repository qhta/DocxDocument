
namespace DocumentModel.Interop.Core;

public interface TextFrame2: InteropObject
{
  public float MarginBottom { get; set; }
  public float MarginLeft { get; set; }
  public float MarginRight { get; set; }
  public float MarginTop { get; set; }
  public MsoTextOrientation Orientation { get; set; }
  public MsoHorizontalAnchor HorizontalAnchor { get; set; }
  public MsoVerticalAnchor VerticalAnchor { get; set; }
  public MsoPathFormat PathFormat { get; set; }
  public MsoWarpFormat WarpFormat { get; set; }
  public MsoPresetTextEffect WordArtformat { get; set; }
  public MsoTriState WordWrap { get; set; }
  public MsoAutoSize AutoSize { get; set; }
  public ThreeDFormat ThreeD { get; }
  public MsoTriState HasText { get; }
  public TextRange2 TextRange { get; }
  public TextColumn2 Column { get; }
  public Ruler2 Ruler { get; }
  public void DeleteText();
  public MsoTriState NoTextRotation { get; set; }
}
