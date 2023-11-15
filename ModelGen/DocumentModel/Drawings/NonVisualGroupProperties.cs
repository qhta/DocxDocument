namespace DocumentModel.Drawings;


/// <summary>
///   Defines the NonVisualGroupProperties Class.
/// </summary>
public partial class NonVisualGroupProperties: ModelElement<DXO13D.NonVisualGroupProperties>
{
  public NonVisualGroupProperties(): base(){ }
  
  public NonVisualGroupProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupProperties(DXO13D.NonVisualGroupProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsLegacyGroup
  {
    get => _Element?.IsLegacyGroup?.Value;
    set => _ExistingElement.IsLegacyGroup = value;
  }
  
}
