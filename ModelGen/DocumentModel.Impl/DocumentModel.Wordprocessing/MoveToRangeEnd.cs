namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToRangeEnd Class.
/// </summary>
public class MoveToRangeEnd: IMoveToRangeEnd
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlValues? DisplacedByCustomXml
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
