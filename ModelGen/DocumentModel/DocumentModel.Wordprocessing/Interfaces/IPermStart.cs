namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public interface IPermStart // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// edGrp
  /// </summary>
  public DocumentModel.Wordprocessing.RangePermissionEditingGroupKind? EditorGroup { get ; set; }
  
  /// <summary>
  /// ed
  /// </summary>
  public System.String? Ed { get ; set; }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public System.Int32? ColumnFirst { get ; set; }
  
  /// <summary>
  /// colLast
  /// </summary>
  public System.Int32? ColumnLast { get ; set; }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public System.Int32? Id { get ; set; }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml { get ; set; }
  
}
