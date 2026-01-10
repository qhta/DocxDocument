namespace DocumentModel.Wordprocessing.OEmbed;

/// <summary>
/// Represents an oEmbed element for embedding external media content in a Wordprocessing document.
/// This interface provides properties for specifying the oEmbed URL, media type, and picture locking behavior for embedded content.
/// </summary>
public interface OEmbed
{
    /// <summary>
    /// The URL used for oEmbed, referencing the external media resource to be embedded in the document.
    /// </summary>
    public string? OEmbedUrl { get; set; }
    /// <summary>
    /// The media type of the embedded content, such as image, video, or rich media.
    /// </summary>
    public string? MediaType { get; set; }
    /// <summary>
    /// Indicates whether picture locking is automatically applied for oEmbed content, controlling edit restrictions on the embedded media.
    /// </summary>
    public bool? PicLocksAutoForOEmbed { get; set; }
}