namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Saving Document As XML File When Custom XML Markup Is Invalid.
/// </summary>
public class SaveInvalidXml: ISaveInvalidXml
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
