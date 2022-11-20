namespace DocumentModel.Wordprocessing;

/// <summary>
/// Only Print Form Field Content.
/// </summary>
public interface IPrintFormsData // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
