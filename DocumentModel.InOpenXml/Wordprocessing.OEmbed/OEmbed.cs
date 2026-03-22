namespace DocumentModel.Wordprocessing.OEmbed;
/// <summary>
/// Represents an oEmbed element for embedding external media content in a Wordprocessing document.
/// This class provides properties for specifying the oEmbed URL, media type, and picture locking behavior for embedded content.
/// </summary>
[OpenXmlType(typeof(DXOWY20OE.OEmbed))]
public partial class OEmbed : ModelElement<DXOWY20OE.OEmbed>
{
 /// <summary>
 /// The URL used for oEmbed, referencing the external media resource to be embedded in the document.
 /// </summary>
 public string? OEmbedUrl { get => _OEmbedUrl; set => UpdateField(ref _OEmbedUrl, value, nameof(OEmbedUrl)); }
 private string? _OEmbedUrl;
 /// <summary>
 /// The media type of the embedded content, such as image, video, or rich media.
 /// </summary>
 public string? MediaType { get => _MediaType; set => UpdateField(ref _MediaType, value, nameof(MediaType)); }
 private string? _MediaType;
 /// <summary>
 /// Indicates whether picture locking is automatically applied for oEmbed content, controlling edit restrictions on the embedded media.
 /// </summary>
 public bool? PicLocksAutoForOEmbed { get => _PicLocksAutoForOEmbed; set => UpdateField(ref _PicLocksAutoForOEmbed, value, nameof(PicLocksAutoForOEmbed)); }
 private bool? _PicLocksAutoForOEmbed;
}