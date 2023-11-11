namespace DocumentModel.Math;


/// <summary>
///   Function Properties.
/// </summary>
public partial class FunctionProperties: ModelElement<DXM.FunctionProperties>
{
  public FunctionProperties(): base(){ }
  
  public FunctionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FunctionProperties(DXM.FunctionProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
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
