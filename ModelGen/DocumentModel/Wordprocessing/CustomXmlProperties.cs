namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of properties which shall be applied to the parent custom XML element.
/// </summary>
public partial class CustomXmlProperties: ModelElement<DXW.CustomXmlProperties>
{
  public CustomXmlProperties(): base(){ }
  
  public CustomXmlProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlProperties(DXW.CustomXmlProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Custom XML Element Placeholder Text.
  /// </summary>
  [DataMember]
  public DMW.CustomXmlPlaceholder? CustomXmlPlaceholder
  {
    get
    {
      return _Element?.GetObject<DMW.CustomXmlPlaceholder,DXW.CustomXmlPlaceholder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CustomXmlPlaceholder,DXW.CustomXmlPlaceholder>(value);
    }
  }
  
}
