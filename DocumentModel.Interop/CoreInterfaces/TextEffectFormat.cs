
namespace DocumentModel.Interop.Core;

public interface TextEffectFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  void ToggleVerticalText();
  MsoTextEffectAlignment Alignment { get; set; }
  MsoTriState FontBold { get; set; }
  MsoTriState FontItalic { get; set; }
  string FontName { get; set; }
  float FontSize { get; set; }
  MsoTriState KernedPairs { get; set; }
  MsoTriState NormalizedHeight { get; set; }
  MsoPresetTextEffectShape PresetShape { get; set; }
  MsoPresetTextEffect PresetTextEffect { get; set; }
  MsoTriState RotatedChars { get; set; }
  string Text { get; set; }
  float Tracking { get; set; }
}