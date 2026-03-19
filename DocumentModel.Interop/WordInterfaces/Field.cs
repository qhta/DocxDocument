namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a field. The Field object is a member of the Fields collection. The Fields collection represents the fields in a selection, range, or document.
/// </summary>
public partial interface Field : InteropObject
{
  /// <summary>
  /// The code.
  /// </summary>
  public Range Code { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdFieldType Type { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  public bool Locked { get; set; }

  /// <summary>
  /// The kind.
  /// </summary>
  public WdFieldKind Kind { get; }

  /// <summary>
  /// The result.
  /// </summary>
  public Range Result { get; set; }

  /// <summary>
  /// The data.
  /// </summary>
  public string Data { get; set; }

  /// <summary>
  /// The next.
  /// </summary>
  public Field Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public Field Previous { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The show codes.
  /// </summary>
  public bool ShowCodes { get; set; }

  /// <summary>
  /// The link format.
  /// </summary>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// The oleformat.
  /// </summary>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// The inline shape.
  /// </summary>
  public InlineShape InlineShape { get; }
}
