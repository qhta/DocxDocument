namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Enabled.
/// </summary>
public interface IEnabled // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
