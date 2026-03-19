namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents options that control how text is retrieved from a Range object.
/// </summary>
public interface TextRetrievalMode : InteropObject
{
  /// <summary>
  /// The view type.
  /// </summary>
  public WdViewType ViewType { get; set; }
  /// <summary>
  /// The duplicate.
  /// </summary>
  public TextRetrievalMode Duplicate { get; }
  /// <summary>
  /// The include hidden text.
  /// </summary>
  public bool IncludeHiddenText { get; set; }
  /// <summary>
  /// The include field codes.
  /// </summary>
  public bool IncludeFieldCodes { get; set; }

}
