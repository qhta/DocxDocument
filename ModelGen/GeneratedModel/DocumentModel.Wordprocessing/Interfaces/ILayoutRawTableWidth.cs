namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
/// </summary>
public interface ILayoutRawTableWidth // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
