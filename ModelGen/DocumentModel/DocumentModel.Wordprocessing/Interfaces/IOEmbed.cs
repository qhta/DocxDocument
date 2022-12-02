namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public interface IOEmbed // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? OEmbedUrl { get ; set; }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? MediaType { get ; set; }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  public Boolean? PicLocksAutoForOEmbed { get ; set; }
  
}
