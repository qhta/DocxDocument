namespace DocumentModel.Wordprocessing;

/// <summary>
/// Save Document as XML File through Custom XSL Transform.
/// </summary>
public interface IUseXsltWhenSaving // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
