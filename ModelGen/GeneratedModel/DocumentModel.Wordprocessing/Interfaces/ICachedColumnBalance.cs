namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Cached Paragraph Information for Column Balancing.
/// </summary>
public interface ICachedColumnBalance // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
