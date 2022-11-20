namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public class PermEnd: IPermEnd
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  public int? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXmlValues? DisplacedByCustomXml
  {
    get;
    set;
  }
  
}
