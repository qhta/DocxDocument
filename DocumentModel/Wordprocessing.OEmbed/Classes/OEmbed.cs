namespace DocumentModel.Wordprocessing.OEmbed;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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