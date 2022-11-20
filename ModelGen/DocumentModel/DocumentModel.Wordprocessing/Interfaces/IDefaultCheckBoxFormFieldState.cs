namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Checkbox Form Field State.
/// </summary>
public interface IDefaultCheckBoxFormFieldState // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
