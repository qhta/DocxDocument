using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings;
/// <summary>
/// Represents a blip (binary large image or picture), providing references and effects for embedded or linked images in a drawing.
/// </summary>
public partial class Blip : ModelElement<DXD.Blip>, IExtendableElement
{
    /// <summary>
    /// Gets or sets the reference to an embedded picture.
    /// </summary>
    public string? Embed { get => _Embed; set => UpdateField(ref _Embed, value, nameof(Embed)); }

    private string? _Embed;
    /// <summary>
    /// Gets or sets the reference to a linked picture.
    /// </summary>
    public string? Link { get; set; }
    /// <summary>
    /// Gets or sets the compression state for the blip.
    /// </summary>
    public BlipCompressionKind? CompressionState { get; set; }
    /// <summary>
    /// Gets or sets the alpha bi-level effect, which applies a threshold to the alpha channel.
    /// </summary>
    public AlphaBiLevel? AlphaBiLevel { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether the alpha ceiling effect is applied.
    /// </summary>
    public bool? AlphaCeiling { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether the alpha floor effect is applied.
    /// </summary>
    public bool? AlphaFloor { get; set; }
    /// <summary>
    /// Gets or sets the alpha inverse effect, which inverts the alpha channel.
    /// </summary>
    public AlphaInverse? AlphaInverse { get; set; }
    /// <summary>
    /// Gets or sets the alpha modulation effect, which modulates the alpha channel using an effect container.
    /// </summary>
    public AlphaModulationEffect? AlphaModulationEffect { get; set; }
    /// <summary>
    /// Gets or sets the alpha modulation fixed effect, which modulates the alpha channel by a fixed amount.
    /// </summary>
    public AlphaModulationFixed? AlphaModulationFixed { get; set; }
    /// <summary>
    /// Gets or sets the alpha replace effect, which replaces the alpha channel with a specified value.
    /// </summary>
    public AlphaReplace? AlphaReplace { get; set; }
    /// <summary>
    /// Gets or sets the bi-level effect, which applies a threshold to the image.
    /// </summary>
    public BiLevel? BiLevel { get; set; }
    /// <summary>
    /// Gets or sets the blur effect, which applies a blur to the image.
    /// </summary>
    public Blur? Blur { get; set; }
    /// <summary>
    /// Gets or sets the color change effect, which modifies the colors in the image.
    /// </summary>
    public ColorChange? ColorChange { get; set; }
    /// <summary>
    /// Gets or sets the color replacement effect, which replaces specific colors in the image.
    /// </summary>
    public ColorReplacement? ColorReplacement { get; set; }
    /// <summary>
    /// Gets or sets the duotone effect, which applies a two-tone color effect to the image.
    /// </summary>
    public Duotone? Duotone { get; set; }
    /// <summary>
    /// Gets or sets the fill overlay effect, which overlays a fill on the image.
    /// </summary>
    public FillOverlay? FillOverlay { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether the image is rendered in grayscale.
    /// </summary>
    public Boolean Grayscale { get; set; }
    /// <summary>
    /// Gets or sets the HSL (Hue, Saturation, Lightness) effect applied to the image.
    /// </summary>
    public Hsl? Hsl { get; set; }
    /// <summary>
    /// Gets or sets the luminance effect, which adjusts the brightness and contrast of the image.
    /// </summary>
    public LuminanceEffect? LuminanceEffect { get; set; }
    /// <summary>
    /// Gets or sets the tint effect, which applies a tint to the image.
    /// </summary>
    public TintEffect? TintEffect { get; set; }
    public IExtensionList? ExtensionList { get; set; }
}