namespace DocumentModel.Wordprocessing.OEmbed;


/// <summary>
///   Defines the OEmbed Class.
/// </summary>
public partial class OEmbed
{
  
  /// <summary>
  ///   oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("oEmbedUrl")]
  public String? OEmbedUrl { get; set; }
  
  
  /// <summary>
  ///   mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("mediaType")]
  public String? MediaType { get; set; }
  
  
  /// <summary>
  ///   picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  [SchemaAttr("picLocksAutoForOEmbed")]
  public Boolean? PicLocksAutoForOEmbed { get; set; }
  
}
