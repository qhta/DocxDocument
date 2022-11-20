namespace DocumentModel.Wordprocessing;

/// <summary>
/// Different Even/Odd Page Headers and Footers.
/// </summary>
public interface IEvenAndOddHeaders // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
