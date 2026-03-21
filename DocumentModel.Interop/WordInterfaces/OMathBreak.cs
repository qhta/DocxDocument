namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents individual line breaks in an equation. Each OMathBreak object is a member of the OMathBreaks collection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak?view=word-pia"/>
public partial interface OMathBreak : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The align at.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak.alignat?view=word-pia"/>
  public int AlignAt { get; set; }
}
