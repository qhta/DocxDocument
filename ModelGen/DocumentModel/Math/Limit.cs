namespace DocumentModel.Math;


/// <summary>
///   Limit (Lower).
/// </summary>
public partial class Limit: ModelElement<DXM.Limit>
{
  public Limit(): base(){ }
  
  public Limit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Limit(DXM.Limit openXmlElement): base(openXmlElement) { }
  
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
