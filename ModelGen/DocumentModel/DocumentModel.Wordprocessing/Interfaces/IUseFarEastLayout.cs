namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Bypass East Asian/Complex Script Layout Code.
/// </summary>
public interface IUseFarEastLayout // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
