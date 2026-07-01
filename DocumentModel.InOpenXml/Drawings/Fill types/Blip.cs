using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;
/// <summary>
/// Represents a blip (binary large image or picture), providing references and effects for embedded or linked images in a drawing.
/// </summary>
[OpenXmlType(typeof(DXD.Blip))]
[DataContract]
[XmlRoot("Blip", Namespace = "DocumentModel.Drawings")]
public partial class Blip : ModelElement<DXD.Blip>, IExtendableElement
{
 /// <summary>
 /// Gets or sets the reference to an embedded picture.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blip.Embed))]
 public string? Embed { get => _Embed; set => UpdateField(ref _Embed, value, nameof(Embed)); }
 private string? _Embed;

 /// <summary>
 /// Gets or sets the reference to a linked picture.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blip.Link))]
 public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }
 private string? _Link;

 /// <summary>
 /// Gets or sets the compression state for the blip.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blip.CompressionState))]
 public BlipCompression? CompressionState { get => _CompressionState; set => UpdateField(ref _CompressionState, value, nameof(CompressionState)); }
 private BlipCompression? _CompressionState;

 /// <summary>
 /// Gets or sets the alpha bi-level effect, which applies a threshold to the alpha channel.
 /// </summary>
 public AlphaBiLevel? AlphaBiLevel { get => _AlphaBiLevel; set => UpdateField(ref _AlphaBiLevel, value, nameof(AlphaBiLevel)); }
 private AlphaBiLevel? _AlphaBiLevel;

 /// <summary>
 /// Gets or sets a value indicating whether the alpha ceiling effect is applied.
 /// </summary>
 public bool? AlphaCeiling { get => _AlphaCeiling; set => UpdateField(ref _AlphaCeiling, value, nameof(AlphaCeiling)); }
 private bool? _AlphaCeiling;

 /// <summary>
 /// Gets or sets a value indicating whether the alpha floor effect is applied.
 /// </summary>
 public bool? AlphaFloor { get => _AlphaFloor; set => UpdateField(ref _AlphaFloor, value, nameof(AlphaFloor)); }
 private bool? _AlphaFloor;

 /// <summary>
 /// Gets or sets the alpha inverse effect, which inverts the alpha channel.
 /// </summary>
 public AlphaInverse? AlphaInverse { get => _AlphaInverse; set => UpdateField(ref _AlphaInverse, value, nameof(AlphaInverse)); }
 private AlphaInverse? _AlphaInverse;

 /// <summary>
 /// Gets or sets the alpha modulation effect, which modulates the alpha channel using an effect container.
 /// </summary>
 public AlphaModulationEffect? AlphaModulationEffect { get => _AlphaModulationEffect; set => UpdateField(ref _AlphaModulationEffect, value, nameof(AlphaModulationEffect)); }
 private AlphaModulationEffect? _AlphaModulationEffect;

 /// <summary>
 /// Gets or sets the alpha modulation fixed effect, which modulates the alpha channel by a fixed amount.
 /// </summary>
 public AlphaModulationFixed? AlphaModulationFixed { get => _AlphaModulationFixed; set => UpdateField(ref _AlphaModulationFixed, value, nameof(AlphaModulationFixed)); }
 private AlphaModulationFixed? _AlphaModulationFixed;

 /// <summary>
 /// Gets or sets the alpha replace effect, which replaces the alpha channel with a specified value.
 /// </summary>
 public AlphaReplace? AlphaReplace { get => _AlphaReplace; set => UpdateField(ref _AlphaReplace, value, nameof(AlphaReplace)); }
 private AlphaReplace? _AlphaReplace;

 /// <summary>
 /// Gets or sets the bi-level effect, which applies a threshold to the image.
 /// </summary>
 public BiLevel? BiLevel { get => _BiLevel; set => UpdateField(ref _BiLevel, value, nameof(BiLevel)); }
 private BiLevel? _BiLevel;

 /// <summary>
 /// Gets or sets the blur effect, which applies a blur to the image.
 /// </summary>
 public Blur? Blur { get => _Blur; set => UpdateField(ref _Blur, value, nameof(Blur)); }
 private Blur? _Blur;

 /// <summary>
 /// Gets or sets the color change effect, which modifies the colors in the image.
 /// </summary>
 public ColorChange? ColorChange { get => _ColorChange; set => UpdateField(ref _ColorChange, value, nameof(ColorChange)); }
 private ColorChange? _ColorChange;

 /// <summary>
 /// Gets or sets the color replacement effect, which replaces specific colors in the image.
 /// </summary>
 public ColorReplacement? ColorReplacement { get => _ColorReplacement; set => UpdateField(ref _ColorReplacement, value, nameof(ColorReplacement)); }
 private ColorReplacement? _ColorReplacement;

 /// <summary>
 /// Gets or sets the duotone effect, which applies a two-tone color effect to the image.
 /// </summary>
 public Duotone? Duotone { get => _Duotone; set => UpdateField(ref _Duotone, value, nameof(Duotone)); }
 private Duotone? _Duotone;

 /// <summary>
 /// Gets or sets the fill overlay effect, which overlays a fill on the image.
 /// </summary>
 public FillOverlay? FillOverlay { get => _FillOverlay; set => UpdateField(ref _FillOverlay, value, nameof(FillOverlay)); }
 private FillOverlay? _FillOverlay;

 /// <summary>
 /// Gets or sets a value indicating whether the image is rendered in grayscale.
 /// </summary>
 public Boolean Grayscale { get => _Grayscale; set => UpdateField(ref _Grayscale, value, nameof(Grayscale)); }
 private Boolean _Grayscale;

 /// <summary>
 /// Gets or sets the HSL (Hue, Saturation, Lightness) effect applied to the image.
 /// </summary>
 public Hsl? Hsl { get => _Hsl; set => UpdateField(ref _Hsl, value, nameof(Hsl)); }
 private Hsl? _Hsl;

 /// <summary>
 /// Gets or sets the luminance effect, which adjusts the brightness and contrast of the image.
 /// </summary>
 public LuminanceEffect? LuminanceEffect { get => _LuminanceEffect; set => UpdateField(ref _LuminanceEffect, value, nameof(LuminanceEffect)); }
 private LuminanceEffect? _LuminanceEffect;

 /// <summary>
 /// Gets or sets the tint effect, which applies a tint to the image.
 /// </summary>
 public TintEffect? TintEffect { get => _TintEffect; set => UpdateField(ref _TintEffect, value, nameof(TintEffect)); }
 private TintEffect? _TintEffect;

 /// <summary>
 /// List of extensions for the blip.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}