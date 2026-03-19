
namespace DocumentModel.Interop.Core;

public interface TextFrame2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  float MarginBottom { get; set; }
  float MarginLeft { get; set; }
  float MarginRight { get; set; }
  float MarginTop { get; set; }
  MsoTextOrientation Orientation { get; set; }
  MsoHorizontalAnchor HorizontalAnchor { get; set; }
  MsoVerticalAnchor VerticalAnchor { get; set; }
  MsoPathFormat PathFormat { get; set; }
  MsoWarpFormat WarpFormat { get; set; }
  MsoPresetTextEffect WordArtformat { get; set; }
  MsoTriState WordWrap { get; set; }
  MsoAutoSize AutoSize { get; set; }
  ThreeDFormat ThreeD { get; }
  MsoTriState HasText { get; }
  TextRange2 TextRange { get; }
  TextColumn2 Column { get; }
  Ruler2 Ruler { get; }
  void DeleteText();
  MsoTriState NoTextRotation { get; set; }
}