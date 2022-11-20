namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Compress Compressible Characters When Using Document Grid.
/// </summary>
public interface IDoNotUseEastAsianBreakRules // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
