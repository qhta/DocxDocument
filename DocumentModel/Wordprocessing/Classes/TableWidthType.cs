namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public partial class TableWidthType
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  public String? Width { get; set; }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthUnitKind? Type { get; set; }
  
}
