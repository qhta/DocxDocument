namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single e-mail signature entry.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry?view=word-pia"/>
public partial interface IEmailSignatureEntry : IModelObject
{
  /// <summary>
  /// Gets the index number of the email signature entry in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets the name of the email signature entry.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailsignatureentry.name?view=word-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
