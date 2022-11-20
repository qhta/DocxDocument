namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Show Visual Indicator For Invalid Custom XML Markup.
/// </summary>
public class DoNotDemarcateInvalidXml: IDoNotDemarcateInvalidXml
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
