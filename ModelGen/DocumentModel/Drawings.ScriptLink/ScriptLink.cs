namespace DocumentModel.Drawings.ScriptLink;


/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public partial class ScriptLink: ModelElement<DXOD21SL.ScriptLink>
{
  public ScriptLink(): base(){ }
  
  public ScriptLink(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScriptLink(DXOD21SL.ScriptLink openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   val, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDSL.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDSL.OfficeArtExtensionList,DXOD21SL.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSL.OfficeArtExtensionList,DXOD21SL.OfficeArtExtensionList>(value);
    }
  }
  
}
