namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Rich Text.
/// </summary>
public partial class RichText: ModelElement<DXDC.RichText>
{
  public RichText(): base(){ }
  
  public RichText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RichText(DXDC.RichText openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BodyProperties,DXD.BodyProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BodyProperties,DXD.BodyProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get
    {
      return _Element?.GetObject<DMD.ListStyle,DXD.ListStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ListStyle,DXD.ListStyle>(value);
    }
  }
  
}
