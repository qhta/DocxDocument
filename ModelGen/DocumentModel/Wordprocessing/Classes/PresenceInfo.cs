namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies uniquely identifying contact information for a person.
/// </summary>
public partial class PresenceInfo
{
  
  /// <summary>
  ///   providerId, this property is only available in Office 2013 and later.
  /// </summary>
  public HexInt? ProviderId { get; set; }
  
  
  /// <summary>
  ///   userId, this property is only available in Office 2013 and later.
  /// </summary>
  public HexInt? UserId { get; set; }
  
}
