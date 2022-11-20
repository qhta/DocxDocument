namespace DocumentModel.Wordprocessing;

/// <summary>
/// First Row of Data Source Contains Column Names.
/// </summary>
public interface IFirstRowHeader // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
