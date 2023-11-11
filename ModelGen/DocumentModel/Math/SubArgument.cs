namespace DocumentModel.Math;


/// <summary>
///   Lower limit (n-ary) .
/// </summary>
public partial class SubArgument: ModelElement<DXM.SubArgument>
{
  public SubArgument(): base(){ }
  
  public SubArgument(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubArgument(DXM.SubArgument openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMM.ArgumentProperties? ArgumentProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ArgumentProperties,DXM.ArgumentProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ArgumentProperties,DXM.ArgumentProperties>(value);
    }
  }
  
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
