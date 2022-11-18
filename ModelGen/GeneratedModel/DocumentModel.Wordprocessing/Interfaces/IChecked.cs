namespace DocumentModel.Wordprocessing;

/// <summary>
/// Checkbox Form Field State.
/// </summary>
public interface IChecked // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
