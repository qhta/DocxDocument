namespace DocumentModel.Office.Word.Y2020.OEmbed;

/// <summary>
/// Defines the OEmbed Class.
/// </summary>
public class OEmbed: IOEmbed
{
  /// <summary>
  /// oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? OEmbedUrl
  {
    get;
    set;
  }
  
  /// <summary>
  /// mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? MediaType
  {
    get;
    set;
  }
  
  /// <summary>
  /// picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  public bool? PicLocksAutoForOEmbed
  {
    get;
    set;
  }
  
}
