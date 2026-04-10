namespace DocumentModel.Drawings;
/// <summary>
///   Represents a pattern fill, including preset pattern type and foreground/background colors.
/// </summary>
[OpenXmlType(typeof(DXD.PatternFill))]
[XmlRoot("PatternFill", Namespace = "DocumentModel.Drawings")]
public partial class PatternFill : ModelElement<DXD.PatternFill>
{
 /// <summary>
 ///   Preset pattern type used for the fill.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PatternFill.Preset))]
 public PresetPattern? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

 private PresetPattern? _Preset;
 /// <summary>
 ///   Foreground color of the pattern.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PatternFill.ForegroundColor))]
 public ForegroundColor? ForegroundColor { get => _ForegroundColor; set => UpdateField(ref _ForegroundColor, value, nameof(ForegroundColor)); }

 private ForegroundColor? _ForegroundColor;
 /// <summary>
 ///   Background color of the pattern.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PatternFill.BackgroundColor))]
 public BackgroundColor? BackgroundColor { get => _BackgroundColor; set => UpdateField(ref _BackgroundColor, value, nameof(BackgroundColor)); }

 private BackgroundColor? _BackgroundColor;
}