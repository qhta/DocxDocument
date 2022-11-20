namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Personal Information from Document Properties.
/// </summary>
public interface IRemovePersonalInformation // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
