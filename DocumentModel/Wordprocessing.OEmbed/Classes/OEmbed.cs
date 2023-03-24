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
  public String? OEmbedUrl { get; set; }

  /// <summary>
  ///   mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? MediaType { get; set; }

  /// <summary>
  ///   picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  public Boolean? PicLocksAutoForOEmbed { get; set; }
}