namespace DocumentModel.Drawings.OEmbed;


/// <summary>
///   Defines the OEmbedShared Class.
/// </summary>
public partial class OEmbedShared: ModelElement<DXOD21OE.OEmbedShared>
{
  public OEmbedShared(): base(){ }
  
  public OEmbedShared(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OEmbedShared(DXOD21OE.OEmbedShared openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? SrcUrl
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SrcUrl);
    }
    set
    {
      _ExistingElement.SrcUrl = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   type, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? Type
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Type);
    }
    set
    {
      _ExistingElement.Type = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDOE.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDOE.OfficeArtExtensionList,DXOD21OE.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDOE.OfficeArtExtensionList,DXOD21OE.OfficeArtExtensionList>(value);
    }
  }
  
}
