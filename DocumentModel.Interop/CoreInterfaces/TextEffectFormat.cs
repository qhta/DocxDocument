
namespace DocumentModel.Interop.Core;

public interface TextEffectFormat: InteropObject
{
  public void ToggleVerticalText();
  public MsoTextEffectAlignment Alignment { get; set; }
  public MsoTriState FontBold { get; set; }
  public MsoTriState FontItalic { get; set; }
  public string FontName { get; set; }
  public float FontSize { get; set; }
  public MsoTriState KernedPairs { get; set; }
  public MsoTriState NormalizedHeight { get; set; }
  public MsoPresetTextEffectShape PresetShape { get; set; }
  public MsoPresetTextEffect PresetTextEffect { get; set; }
  public MsoTriState RotatedChars { get; set; }
  public string Text { get; set; }
  public float Tracking { get; set; }
}
