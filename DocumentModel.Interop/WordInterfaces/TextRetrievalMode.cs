namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents options that control how text is retrieved from a Range object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode?view=word-pia"/>
public interface TextRetrievalMode : InteropObject
{
  /// <summary>
  /// Returns or sets the view for the TextRetrievalMode object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.viewtype?view=word-pia"/>
  public ViewType ViewType { get; set; }
  /// <summary>
  /// Returns a read-only TextRetrievalMode object that represents options related to retrieving text from the
  /// specified Range object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.duplicate?view=word-pia"/>
  public TextRetrievalMode Duplicate { get; }
  /// <summary>
  /// True if the text retrieved from the specified range includes hidden text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.includehiddentext?view=word-pia"/>
  public bool IncludeHiddenText { get; set; }
  /// <summary>
  /// True if the text retrieved from the specified range includes field codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textretrievalmode.includefieldcodes?view=word-pia"/>
  public bool IncludeFieldCodes { get; set; }

}
