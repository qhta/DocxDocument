namespace DocumentModel.Drawings;
/// <summary>
/// Represents an image effect, including visibility, a variety of artistic effects, image adjustments, and extension options.
/// </summary>
[OpenXmlType(typeof(DXO10D.ImageEffect))]
public partial class ImageEffect : ModelElement<DXO10D.ImageEffect>, IExtendableElement
{
 /// <summary>
 /// Gets or sets a value indicating whether the effect is visible.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.Visible))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public bool? Visible { get => _Visible; set => UpdateField(ref _Visible, value, nameof(Visible)); }

 private bool? _Visible;
 /// <summary>
 /// Artistic blur effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticBlur))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticBlur? ArtisticBlur { get => _ArtisticBlur; set => UpdateField(ref _ArtisticBlur, value, nameof(ArtisticBlur)); }

 private ArtisticBlur? _ArtisticBlur;
 /// <summary>
 /// Artistic cement effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticCement))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticCement? ArtisticCement { get => _ArtisticCement; set => UpdateField(ref _ArtisticCement, value, nameof(ArtisticCement)); }

 private ArtisticCement? _ArtisticCement;
 /// <summary>
 /// Artistic chalk sketch effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticChalkSketch))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticChalkSketch? ArtisticChalkSketch { get => _ArtisticChalkSketch; set => UpdateField(ref _ArtisticChalkSketch, value, nameof(ArtisticChalkSketch)); }

 private ArtisticChalkSketch? _ArtisticChalkSketch;
 /// <summary>
 /// Artistic crisscross etching effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticCrisscrossEtching))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticCrisscrossEtching? ArtisticCrisscrossEtching { get => _ArtisticCrisscrossEtching; set => UpdateField(ref _ArtisticCrisscrossEtching, value, nameof(ArtisticCrisscrossEtching)); }

 private ArtisticCrisscrossEtching? _ArtisticCrisscrossEtching;
 /// <summary>
 /// Artistic cutout effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticCutout))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticCutout? ArtisticCutout { get => _ArtisticCutout; set => UpdateField(ref _ArtisticCutout, value, nameof(ArtisticCutout)); }

 private ArtisticCutout? _ArtisticCutout;
 /// <summary>
 /// Artistic film grain effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticFilmGrain))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticFilmGrain? ArtisticFilmGrain { get => _ArtisticFilmGrain; set => UpdateField(ref _ArtisticFilmGrain, value, nameof(ArtisticFilmGrain)); }

 private ArtisticFilmGrain? _ArtisticFilmGrain;
 /// <summary>
 /// Artistic glass effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticGlass))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticGlass? ArtisticGlass { get => _ArtisticGlass; set => UpdateField(ref _ArtisticGlass, value, nameof(ArtisticGlass)); }

 private ArtisticGlass? _ArtisticGlass;
 /// <summary>
 /// Artistic diffused glow effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticGlowDiffused))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticGlowDiffused? ArtisticGlowDiffused { get => _ArtisticGlowDiffused; set => UpdateField(ref _ArtisticGlowDiffused, value, nameof(ArtisticGlowDiffused)); }

 private ArtisticGlowDiffused? _ArtisticGlowDiffused;
 /// <summary>
 /// Artistic glow edges effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticGlowEdges))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticGlowEdges? ArtisticGlowEdges { get => _ArtisticGlowEdges; set => UpdateField(ref _ArtisticGlowEdges, value, nameof(ArtisticGlowEdges)); }

 private ArtisticGlowEdges? _ArtisticGlowEdges;
 /// <summary>
 /// Artistic light screen effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticLightScreen))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticLightScreen? ArtisticLightScreen { get => _ArtisticLightScreen; set => UpdateField(ref _ArtisticLightScreen, value, nameof(ArtisticLightScreen)); }

 private ArtisticLightScreen? _ArtisticLightScreen;
 /// <summary>
 /// Artistic line drawing effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticLineDrawing))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticLineDrawing? ArtisticLineDrawing { get => _ArtisticLineDrawing; set => UpdateField(ref _ArtisticLineDrawing, value, nameof(ArtisticLineDrawing)); }

 private ArtisticLineDrawing? _ArtisticLineDrawing;
 /// <summary>
 /// Artistic marker effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticMarker))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticMarker? ArtisticMarker { get => _ArtisticMarker; set => UpdateField(ref _ArtisticMarker, value, nameof(ArtisticMarker)); }

 private ArtisticMarker? _ArtisticMarker;
 /// <summary>
 /// Artistic mosaic bubbles effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticMosaicBubbles))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticMosaicBubbles? ArtisticMosaicBubbles { get => _ArtisticMosaicBubbles; set => UpdateField(ref _ArtisticMosaicBubbles, value, nameof(ArtisticMosaicBubbles)); }

 private ArtisticMosaicBubbles? _ArtisticMosaicBubbles;
 /// <summary>
 /// Artistic paint strokes effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPaintStrokes))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPaintStrokes? ArtisticPaintStrokes { get => _ArtisticPaintStrokes; set => UpdateField(ref _ArtisticPaintStrokes, value, nameof(ArtisticPaintStrokes)); }

 private ArtisticPaintStrokes? _ArtisticPaintStrokes;
 /// <summary>
 /// Artistic paint brush effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPaintBrush))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPaintBrush? ArtisticPaintBrush { get => _ArtisticPaintBrush; set => UpdateField(ref _ArtisticPaintBrush, value, nameof(ArtisticPaintBrush)); }

 private ArtisticPaintBrush? _ArtisticPaintBrush;
 /// <summary>
 /// Artistic pastels smooth effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPastelsSmooth))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPastelsSmooth? ArtisticPastelsSmooth { get => _ArtisticPastelsSmooth; set => UpdateField(ref _ArtisticPastelsSmooth, value, nameof(ArtisticPastelsSmooth)); }

 private ArtisticPastelsSmooth? _ArtisticPastelsSmooth;
 /// <summary>
 /// Artistic pencil grayscale effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPencilGrayscale))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPencilGrayscale? ArtisticPencilGrayscale { get => _ArtisticPencilGrayscale; set => UpdateField(ref _ArtisticPencilGrayscale, value, nameof(ArtisticPencilGrayscale)); }

 private ArtisticPencilGrayscale? _ArtisticPencilGrayscale;
 /// <summary>
 /// Artistic pencil sketch effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPencilSketch))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPencilSketch? ArtisticPencilSketch { get => _ArtisticPencilSketch; set => UpdateField(ref _ArtisticPencilSketch, value, nameof(ArtisticPencilSketch)); }

 private ArtisticPencilSketch? _ArtisticPencilSketch;
 /// <summary>
 /// Artistic photocopy effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPhotocopy))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPhotocopy? ArtisticPhotocopy { get => _ArtisticPhotocopy; set => UpdateField(ref _ArtisticPhotocopy, value, nameof(ArtisticPhotocopy)); }

 private ArtisticPhotocopy? _ArtisticPhotocopy;
 /// <summary>
 /// Artistic plastic wrap effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticPlasticWrap))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticPlasticWrap? ArtisticPlasticWrap { get => _ArtisticPlasticWrap; set => UpdateField(ref _ArtisticPlasticWrap, value, nameof(ArtisticPlasticWrap)); }

 private ArtisticPlasticWrap? _ArtisticPlasticWrap;
 /// <summary>
 /// Artistic texturizer effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticTexturizer))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticTexturizer? ArtisticTexturizer { get => _ArtisticTexturizer; set => UpdateField(ref _ArtisticTexturizer, value, nameof(ArtisticTexturizer)); }

 private ArtisticTexturizer? _ArtisticTexturizer;
 /// <summary>
 /// Artistic watercolor sponge effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ArtisticWatercolorSponge))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ArtisticWatercolorSponge? ArtisticWatercolorSponge { get => _ArtisticWatercolorSponge; set => UpdateField(ref _ArtisticWatercolorSponge, value, nameof(ArtisticWatercolorSponge)); }

 private ArtisticWatercolorSponge? _ArtisticWatercolorSponge;
 /// <summary>
 /// Background removal effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.BackgroundRemoval))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public BackgroundRemoval? BackgroundRemoval { get => _BackgroundRemoval; set => UpdateField(ref _BackgroundRemoval, value, nameof(BackgroundRemoval)); }

 private BackgroundRemoval? _BackgroundRemoval;
 /// <summary>
 /// Brightness and contrast adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.BrightnessContrast))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public BrightnessContrast? BrightnessContrast { get => _BrightnessContrast; set => UpdateField(ref _BrightnessContrast, value, nameof(BrightnessContrast)); }

 private BrightnessContrast? _BrightnessContrast;
 /// <summary>
 /// Color temperature adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.ColorTemperature))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ColorTemperature? ColorTemperature { get => _ColorTemperature; set => UpdateField(ref _ColorTemperature, value, nameof(ColorTemperature)); }

 private ColorTemperature? _ColorTemperature;
 /// <summary>
 /// Saturation adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.Saturation))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public Saturation? Saturation { get => _Saturation; set => UpdateField(ref _Saturation, value, nameof(Saturation)); }

 private Saturation? _Saturation;
 /// <summary>
 /// Sharpen or soften adjustment.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.ImageEffect.SharpenSoften))]
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public SharpenSoften? SharpenSoften { get => _SharpenSoften; set => UpdateField(ref _SharpenSoften, value, nameof(SharpenSoften)); }

 private SharpenSoften? _SharpenSoften;
 /// <summary>
 /// List of extensions for the image effect.
 /// </summary>
 [OpenXmlElement(typeof(DXO10D.ImageEffect))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}