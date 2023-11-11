namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a gradient fill. A gradient fill is a fill that is characterized by a smooth gradual transition from one color to the next.
/// </summary>
public partial class GradientFillProperties: ModelElement<DXO10W.GradientFillProperties>
{
  public GradientFillProperties(): base(){ }
  
  public GradientFillProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientFillProperties(DXO10W.GradientFillProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  [DataMember]
  public DMW10.GradientStopList? GradientStopList
  {
    get
    {
      return _Element?.GetObject<DMW10.GradientStopList,DXO10W.GradientStopList>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.GradientStopList,DXO10W.GradientStopList>(value);
    }
  }
  
  [DataMember]
  public DMW10.LinearShadeProperties? LinearShadeProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.LinearShadeProperties,DXO10W.LinearShadeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.LinearShadeProperties,DXO10W.LinearShadeProperties>(value);
    }
  }
  
  [DataMember]
  public DMW10.PathShadeProperties? PathShadeProperties
  {
    get
    {
      return _Element?.GetObject<DMW10.PathShadeProperties,DXO10W.PathShadeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.PathShadeProperties,DXO10W.PathShadeProperties>(value);
    }
  }
  
}
