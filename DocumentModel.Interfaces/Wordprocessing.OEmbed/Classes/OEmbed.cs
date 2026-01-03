namespace DocumentModel.Wordprocessing.OEmbed;

/// <summary>
///   Defines the OEmbed Class.
/// </summary>
public interface OEmbed: IModelElement
{
  /// <summary>
  ///   oEmbedUrl
  /// </summary>
  public string? OEmbedUrl { get; set; }
  /// <summary>
  ///   mediaType
  /// </summary>
  public string? MediaType { get; set; }
  /// <summary>
  ///   picLocksAutoForOEmbed
  /// </summary>
  public bool? PicLocksAutoForOEmbed { get; set; }
}