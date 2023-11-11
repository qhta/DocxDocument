namespace DocumentModel.Math;


/// <summary>
///   Degree.
/// </summary>
public partial class Degree: ModelElement<DXM.Degree>
{
  public Degree(): base(){ }
  
  public Degree(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Degree(DXM.Degree openXmlElement): base(openXmlElement) { }
  
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
