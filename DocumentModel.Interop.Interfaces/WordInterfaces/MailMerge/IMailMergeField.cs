namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mail merge field in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield?view=word-pia"/>
public interface IMailMergeField : IInteropObject
{
  /// <summary>
  /// Returns the type of mail merge field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.type?view=word-pia"/>
  public FieldType Type { get; }

  /// <summary>
  /// Returns or sets whether the mail merge field is locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Returns or sets the field code text for the mail merge field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.code?view=word-pia"/>
  public IRange Code { get; set; }

  /// <summary>
  /// Returns the next mail merge field in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.next?view=word-pia"/>
  public IMailMergeField Next { get; }

  /// <summary>
  /// Returns the previous mail merge field in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.previous?view=word-pia"/>
  public IMailMergeField Previous { get; }


  #region methods

/// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefield.select?view=word-pia"/>
  public void Select();

  #endregion methods
}
