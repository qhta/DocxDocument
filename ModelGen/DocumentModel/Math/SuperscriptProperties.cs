namespace DocumentModel.Math;


/// <summary>
///   Superscript Properties.
/// </summary>
public partial class SuperscriptProperties: ModelElement<DXM.SuperscriptProperties>
{
  public SuperscriptProperties(): base(){ }
  
  public SuperscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuperscriptProperties(DXM.SuperscriptProperties openXmlElement): base(openXmlElement) { }
  
  
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
