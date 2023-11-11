namespace DocumentModel.Math;


/// <summary>
///   Numerator.
/// </summary>
public partial class Numerator: ModelElement<DXM.Numerator>
{
  public Numerator(): base(){ }
  
  public Numerator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Numerator(DXM.Numerator openXmlElement): base(openXmlElement) { }
  
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
