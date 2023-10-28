namespace DocumentModel.Word13;


/// <summary>
///   This element specifies contact information for an author of at least one comment or revision in the current document.
/// </summary>
public partial class Person
{
  public String? Contact { get; set; }
  
  
  /// <summary>
  ///   author, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Author { get; set; }
  
  
  /// <summary>
  ///   PresenceInfo.
  /// </summary>
  public DMW13.PresenceInfo? PresenceInfo { get; set; }
  
}
