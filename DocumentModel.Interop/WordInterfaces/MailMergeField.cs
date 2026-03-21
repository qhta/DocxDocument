namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mail merge field in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield?view=word-pia"/>
public partial interface MailMergeField : InteropObject
{
  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.type?view=word-pia"/>
  public WdFieldType Type { get; }

  /// <summary>
  /// Returns or sets whether locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns or sets the code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.code?view=word-pia"/>
  public Range Code { get; set; }

  /// <summary>
  /// Returns the next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.next?view=word-pia"/>
  public MailMergeField Next { get; }

  /// <summary>
  /// Returns the previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.previous?view=word-pia"/>
  public MailMergeField Previous { get; }
}
