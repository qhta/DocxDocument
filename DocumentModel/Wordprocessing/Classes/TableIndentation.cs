namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public partial class TableIndentation
{
  /// <summary>
  /// w
  /// </summary>
  public Int32? Width { get; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthUnitKind? Type { get; set; }
  
}
