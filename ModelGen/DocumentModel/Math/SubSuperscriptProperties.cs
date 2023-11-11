namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Properties.
/// </summary>
public partial class SubSuperscriptProperties: ModelElement<DXM.SubSuperscriptProperties>
{
  public SubSuperscriptProperties(): base(){ }
  
  public SubSuperscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubSuperscriptProperties(DXM.SubSuperscriptProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Align Scripts.
  /// </summary>
  [DataMember]
  public DMM.AlignScripts? AlignScripts
  {
    get
    {
      return _Element?.GetObject<DMM.AlignScripts,DXM.AlignScripts>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.AlignScripts,DXM.AlignScripts>(value);
    }
  }
  
  
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
