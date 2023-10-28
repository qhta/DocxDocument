namespace DocumentModel.Word13;


/// <summary>
///   This element specifies uniquely identifying contact information for a person.
/// </summary>
public partial class PresenceInfo
{
  
  /// <summary>
  ///   providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ProviderId { get; set; }
  
  
  /// <summary>
  ///   userId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? UserId { get; set; }
  
}
