namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public class PermStart: IPermStart
{
  /// <summary>
  /// edGrp
  /// </summary>
  public RangePermissionEditingGroupValues? EditorGroup
  {
    get;
    set;
  }
  
  /// <summary>
  /// ed
  /// </summary>
  public string? Ed
  {
    get;
    set;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public int? ColumnFirst
  {
    get;
    set;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public int? ColumnLast
  {
    get;
    set;
  }
  
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
