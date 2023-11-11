namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the TextProperties Class.
/// </summary>
public partial class TextProperties: ModelElement<DXDC.TextProperties>
{
  public TextProperties(): base(){ }
  
  public TextProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextProperties(DXDC.TextProperties openXmlElement): base(openXmlElement) { }
  
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
