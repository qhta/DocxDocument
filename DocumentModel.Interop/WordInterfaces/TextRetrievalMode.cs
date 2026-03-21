namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents options that control how text is retrieved from a Range object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode?view=word-pia"/>
public interface TextRetrievalMode : InteropObject
{
  /// <summary>
  /// The view type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.viewtype?view=word-pia"/>
  public WdViewType ViewType { get; set; }
  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.duplicate?view=word-pia"/>
  public TextRetrievalMode Duplicate { get; }
  /// <summary>
  /// The include hidden text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.includehiddentext?view=word-pia"/>
  public bool IncludeHiddenText { get; set; }
  /// <summary>
  /// The include field codes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.includefieldcodes?view=word-pia"/>
  public bool IncludeFieldCodes { get; set; }

}
