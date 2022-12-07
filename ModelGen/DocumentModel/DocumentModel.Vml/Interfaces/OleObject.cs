namespace DocumentModel.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public interface OleObject
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public OleKind? Type { get ; set; }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public OleDrawAspectKind? DrawAspect { get ; set; }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public OleUpdateMode? UpdateMode { get ; set; }
  
}
