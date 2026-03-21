namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mail merge field in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield?view=word-pia"/>
public partial interface MailMergeField : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.type?view=word-pia"/>
  public WdFieldType Type { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// The code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.code?view=word-pia"/>
  public Range Code { get; set; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.next?view=word-pia"/>
  public MailMergeField Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.previous?view=word-pia"/>
  public MailMergeField Previous { get; }
}
