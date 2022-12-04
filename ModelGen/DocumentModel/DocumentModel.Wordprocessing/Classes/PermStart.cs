namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public class PermStart
{
  /// <summary>
  /// edGrp
  /// </summary>
  public RangePermissionEditingGroupKind? EditorGroup
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get;
    set;
  }
  
}
