namespace DocumentModel.Wordprocessing;

/// <summary>
/// Hide Style From User Interface.
/// </summary>
public interface IStyleHidden // : DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnlyValues? Val { get ; set; }
  
}
