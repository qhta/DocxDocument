namespace DocumentModel.Math;


/// <summary>
///   Defines the OfficeMathArgumentType Class.
/// </summary>
public partial class OfficeMathArgumentType: ModelElement<DXM.OfficeMathArgumentType>
{
  public OfficeMathArgumentType(): base(){ }
  
  public OfficeMathArgumentType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfficeMathArgumentType(DXM.OfficeMathArgumentType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Argument Properties.
  /// </summary>
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
  
}
