namespace DocumentModel.Interop;

/// <summary>
/// Represents a single caption that can be automatically added when items such as tables, pictures, or OLE objects are inserted into a document.
/// </summary>
public interface AutoCaption : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The auto insert.
  /// </summary>
  public bool AutoInsert { get; set; }
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
  /// <summary>
  /// The caption label.
  /// </summary>
  public object CaptionLabel { get; set; }

}
