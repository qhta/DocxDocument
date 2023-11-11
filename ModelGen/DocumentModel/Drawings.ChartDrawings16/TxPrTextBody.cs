namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TxPrTextBody Class.
/// </summary>
public partial class TxPrTextBody: ModelElement<DXO16DCD.TxPrTextBody>
{
  public TxPrTextBody(): base(){ }
  
  public TxPrTextBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TxPrTextBody(DXO16DCD.TxPrTextBody openXmlElement): base(openXmlElement) { }
  
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
