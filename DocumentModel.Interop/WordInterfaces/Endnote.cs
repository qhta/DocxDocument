namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an endnote.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote?view=word-pia"/>
public partial interface Endnote : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The reference.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote.reference?view=word-pia"/>
  public Range Reference { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.endnote.index?view=word-pia"/>
  public int Index { get; }
}
