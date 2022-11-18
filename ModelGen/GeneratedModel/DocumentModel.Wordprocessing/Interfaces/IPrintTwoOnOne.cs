namespace DocumentModel.Wordprocessing;

/// <summary>
/// Print Two Pages Per Sheet.
/// </summary>
public interface IPrintTwoOnOne // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
