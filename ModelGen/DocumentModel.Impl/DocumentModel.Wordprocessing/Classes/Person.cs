namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Person Class.
/// </summary>
public class PersonImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Word.Person>, Person
{
  /// <summary>
  /// PresenceInfo.
  /// </summary>
  public PresenceInfo? PresenceInfo
  {
    get;
    set;
  }
  
}
