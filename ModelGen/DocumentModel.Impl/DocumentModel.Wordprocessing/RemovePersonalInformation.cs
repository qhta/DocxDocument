namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Personal Information from Document Properties.
/// </summary>
public class RemovePersonalInformation: IRemovePersonalInformation
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
