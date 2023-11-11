namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
public partial class RichTextBody: ModelElement<DXO16DCD.RichTextBody>
{
  public RichTextBody(): base(){ }
  
  public RichTextBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RichTextBody(DXO16DCD.RichTextBody openXmlElement): base(openXmlElement) { }
  
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
