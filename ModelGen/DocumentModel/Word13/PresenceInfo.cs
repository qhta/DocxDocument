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
  public String? ProviderId
  {
    get => _Element?.ProviderId;
    set => _ExistingElement.ProviderId = value;
  }
  
  
  /// <summary>
  ///   userId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? UserId
  {
    get => _Element?.UserId;
    set => _ExistingElement.UserId = value;
  }
  
}
