namespace DocumentModel.WebExtensions;
/// <summary>
///   Defines the Snapshot Class.
/// </summary>
[OpenXmlType(typeof(DXO13WE.Snapshot))]
[XmlRoot("Snapshot", Namespace = "DocumentModel.WebExtensions")]
public class Snapshot : ModelElement<DXO13WE.Snapshot>
{
 /// <summary>
 /// Specifies the relationship identifier for embedded image data.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.Snapshot.Embed))]
 public string? Embed { get => _Embed; set => UpdateField(ref _Embed, value, nameof(Embed)); }

 private string? _Embed;
 /// <summary>
 /// Specifies the relationship identifier for linked image data.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.Snapshot.Link))]
 public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }

 private string? _Link;
 /// <summary>
 /// Specifies the compression setting applied to the image.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13WE.Snapshot.CompressionState))]
 public DMD.BlipCompression? CompressionState { get => _CompressionState; set => UpdateField(ref _CompressionState, value, nameof(CompressionState)); }

 private DMD.BlipCompression? _CompressionState;
 /// <summary>
 /// Specifies the alpha bi-level effect.
 /// </summary>
 public DMD.AlphaBiLevel? AlphaBiLevel { get => _AlphaBiLevel; set => UpdateField(ref _AlphaBiLevel, value, nameof(AlphaBiLevel)); }

 private DMD.AlphaBiLevel? _AlphaBiLevel;
 /// <summary>
 /// Specifies whether alpha values are clipped at the upper bound.
 /// </summary>
 public bool? AlphaCeiling { get => _AlphaCeiling; set => UpdateField(ref _AlphaCeiling, value, nameof(AlphaCeiling)); }

 private bool? _AlphaCeiling;
 /// <summary>
 /// Specifies whether alpha values are clipped at the lower bound.
 /// </summary>
 public bool? AlphaFloor { get => _AlphaFloor; set => UpdateField(ref _AlphaFloor, value, nameof(AlphaFloor)); }

 private bool? _AlphaFloor;
 /// <summary>
 /// Specifies the alpha inversion effect.
 /// </summary>
 public DMD.AlphaInverse? AlphaInverse { get => _AlphaInverse; set => UpdateField(ref _AlphaInverse, value, nameof(AlphaInverse)); }

 private DMD.AlphaInverse? _AlphaInverse;
 /// <summary>
 /// Specifies the alpha modulation effect.
 /// </summary>
 public DMD.AlphaModulationEffect? AlphaModulationEffect { get => _AlphaModulationEffect; set => UpdateField(ref _AlphaModulationEffect, value, nameof(AlphaModulationEffect)); }

 private DMD.AlphaModulationEffect? _AlphaModulationEffect;
 /// <summary>
 /// Specifies the fixed alpha modulation effect.
 /// </summary>
 public DMD.AlphaModulationFixed? AlphaModulationFixed { get => _AlphaModulationFixed; set => UpdateField(ref _AlphaModulationFixed, value, nameof(AlphaModulationFixed)); }

 private DMD.AlphaModulationFixed? _AlphaModulationFixed;
 /// <summary>
 /// Specifies the alpha replacement effect.
 /// </summary>
 public DMD.AlphaReplace? AlphaReplace { get => _AlphaReplace; set => UpdateField(ref _AlphaReplace, value, nameof(AlphaReplace)); }

 private DMD.AlphaReplace? _AlphaReplace;
 /// <summary>
 /// Specifies the bi-level effect.
 /// </summary>
 public DMD.BiLevel? BiLevel { get => _BiLevel; set => UpdateField(ref _BiLevel, value, nameof(BiLevel)); }

 private DMD.BiLevel? _BiLevel;
 /// <summary>
 /// Specifies the blur effect.
 /// </summary>
 public DMD.Blur? Blur { get => _Blur; set => UpdateField(ref _Blur, value, nameof(Blur)); }

 private DMD.Blur? _Blur;
 /// <summary>
 /// Specifies the color change effect.
 /// </summary>
 public DMD.ColorChange? ColorChange { get => _ColorChange; set => UpdateField(ref _ColorChange, value, nameof(ColorChange)); }

 private DMD.ColorChange? _ColorChange;
 /// <summary>
 /// Specifies the color replacement effect.
 /// </summary>
 public DMD.ColorReplacement? ColorReplacement { get => _ColorReplacement; set => UpdateField(ref _ColorReplacement, value, nameof(ColorReplacement)); }

 private DMD.ColorReplacement? _ColorReplacement;
 /// <summary>
 /// Specifies the duotone effect.
 /// </summary>
 public DMD.Duotone? Duotone { get => _Duotone; set => UpdateField(ref _Duotone, value, nameof(Duotone)); }

 private DMD.Duotone? _Duotone;
 /// <summary>
 /// Specifies the fill overlay effect.
 /// </summary>
 public DMD.FillOverlay? FillOverlay { get => _FillOverlay; set => UpdateField(ref _FillOverlay, value, nameof(FillOverlay)); }

 private DMD.FillOverlay? _FillOverlay;
 /// <summary>
 /// Specifies whether grayscale rendering is applied.
 /// </summary>
 public Boolean Grayscale { get => _Grayscale; set => UpdateField(ref _Grayscale, value, nameof(Grayscale)); }

 private Boolean _Grayscale;
 /// <summary>
 /// Specifies the hue-saturation-luminance effect.
 /// </summary>
 public DMD.Hsl? Hsl { get => _Hsl; set => UpdateField(ref _Hsl, value, nameof(Hsl)); }

 private DMD.Hsl? _Hsl;
 /// <summary>
 /// Specifies the luminance effect.
 /// </summary>
 public DMD.LuminanceEffect? LuminanceEffect { get => _LuminanceEffect; set => UpdateField(ref _LuminanceEffect, value, nameof(LuminanceEffect)); }

 private DMD.LuminanceEffect? _LuminanceEffect;
 /// <summary>
 /// Specifies the tint effect.
 /// </summary>
 public DMD.TintEffect? TintEffect { get => _TintEffect; set => UpdateField(ref _TintEffect, value, nameof(TintEffect)); }

 private DMD.TintEffect? _TintEffect;
 /// <summary>
 /// Specifies the list of blip extensions.
 /// </summary>
 public DMD.BlipExtensionList? BlipExtensionList { get => _BlipExtensionList; set => UpdateField(ref _BlipExtensionList, value, nameof(BlipExtensionList)); }

 private DMD.BlipExtensionList? _BlipExtensionList;
}