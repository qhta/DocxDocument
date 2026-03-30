namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a range of text that has been updated by a co-author.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdate?view=word-pia"/>
public interface ICoAuthUpdate : IModelObject
{
  /// <summary>
  /// Gets the range of text that was updated by a co-author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthupdate.range?view=word-pia"/>
  public IRange Range { get; }

}
