namespace DocumentModel.Wordprocessing;

/// <summary>
/// Print Body Text before Header/Footer Contents.
/// </summary>
public interface IPrintBodyTextBeforeHeader // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
