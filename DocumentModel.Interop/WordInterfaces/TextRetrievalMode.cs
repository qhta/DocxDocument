namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents options that control how text is retrieved from a Range object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode?view=word-pia"/>
public interface TextRetrievalMode : InteropObject
{
  /// <summary>
  /// The view type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.viewtype?view=word-pia"/>
  public WdViewType ViewType { get; set; }
  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.duplicate?view=word-pia"/>
  public TextRetrievalMode Duplicate { get; }
  /// <summary>
  /// The include hidden text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.includehiddentext?view=word-pia"/>
  public bool IncludeHiddenText { get; set; }
  /// <summary>
  /// The include field codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.includefieldcodes?view=word-pia"/>
  public bool IncludeFieldCodes { get; set; }

}
