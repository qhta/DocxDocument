namespace DocumentModel.Wordprocessing.OEmbed;

/// <summary>
///   Defines the OEmbed Class.
/// </summary>
public class OEmbed: ModelElement
{
  /// <summary>
  ///   oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? OEmbedUrl { get; set; }
  /// <summary>
  ///   mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? MediaType { get; set; }
  /// <summary>
  ///   picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  public bool? PicLocksAutoForOEmbed { get; set; }
}