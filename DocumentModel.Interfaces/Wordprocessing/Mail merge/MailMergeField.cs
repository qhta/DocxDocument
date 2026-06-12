namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single mail merge field in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield?view=word-pia"/>
public partial interface IMailMergeField : IModelObject
{
  /// <summary>
  /// Returns the type of mail merge field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.type?view=word-pia"/>
  public FieldType Type { get; }

  /// <summary>
  /// Returns or sets whether the mail merge field is locked.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.locked?view=word-pia"/>
  public bool Locked { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the field code text for the mail merge field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.code?view=word-pia"/>
  public IRange Code { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the next mail merge field in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.next?view=word-pia"/>
  public IMailMergeField Next { get; }

  /// <summary>
  /// Returns the previous mail merge field in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.previous?view=word-pia"/>
  public IMailMergeField Previous { get; }
}
