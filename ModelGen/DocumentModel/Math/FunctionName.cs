namespace DocumentModel.Math;


/// <summary>
///   Function Name.
/// </summary>
public partial class FunctionName: ModelElement<DXM.FunctionName>
{
  public FunctionName(): base(){ }
  
  public FunctionName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FunctionName(DXM.FunctionName openXmlElement): base(openXmlElement) { }
  
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
