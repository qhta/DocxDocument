namespace DocumentModel.Word20;


/// <summary>
///   Defines the OEmbed Class.
/// </summary>
public partial class OEmbed: ModelElement<DXOW20OE.OEmbed>
{
  public OEmbed(): base(){ }
  
  public OEmbed(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OEmbed(DXOW20OE.OEmbed openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   oEmbedUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? OEmbedUrl
  {
    get => _Element?.OEmbedUrl;
    set => _ExistingElement.OEmbedUrl = value;
  }
  
  
  /// <summary>
  ///   mediaType, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? MediaType
  {
    get => _Element?.MediaType;
    set => _ExistingElement.MediaType = value;
  }
  
  
  /// <summary>
  ///   picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public Boolean? PicLocksAutoForOEmbed
  {
    get => _Element?.PicLocksAutoForOEmbed?.Value;
    set => _ExistingElement.PicLocksAutoForOEmbed = value;
  }
  
}
