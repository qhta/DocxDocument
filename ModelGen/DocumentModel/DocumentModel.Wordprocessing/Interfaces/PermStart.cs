namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public interface PermStart // : System.Boolean
{
  /// <summary>
  /// edGrp
  /// </summary>
  public RangePermissionEditingGroupKind? EditorGroup { get ; set; }
  
  /// <summary>
  /// ed
  /// </summary>
  public String? Ed { get ; set; }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public Int32? ColumnFirst { get ; set; }
  
  /// <summary>
  /// colLast
  /// </summary>
  public Int32? ColumnLast { get ; set; }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public Int32? Id { get ; set; }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get ; set; }
  
}
