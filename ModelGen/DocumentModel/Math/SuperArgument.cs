namespace DocumentModel.Math;


/// <summary>
///   Upper limit (n-ary).
/// </summary>
public partial class SuperArgument: ModelElement<DXM.SuperArgument>
{
  public SuperArgument(): base(){ }
  
  public SuperArgument(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuperArgument(DXM.SuperArgument openXmlElement): base(openXmlElement) { }
  
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
