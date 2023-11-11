namespace DocumentModel.Math;


/// <summary>
///   Denominator.
/// </summary>
public partial class Denominator: ModelElement<DXM.Denominator>
{
  public Denominator(): base(){ }
  
  public Denominator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Denominator(DXM.Denominator openXmlElement): base(openXmlElement) { }
  
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
