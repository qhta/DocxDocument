namespace DocumentModel.Word13;


/// <summary>
///   This element specifies uniquely identifying contact information for a person.
/// </summary>
public partial class PresenceInfo: ModelElement<DXO13W.PresenceInfo>
{
  public PresenceInfo(): base(){ }
  
  public PresenceInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresenceInfo(DXO13W.PresenceInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   providerId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ProviderId
  {
    get => HexIntConverter.GetValue(_Element?.ProviderId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   userId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? UserId
  {
    get => HexIntConverter.GetValue(_Element?.UserId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
