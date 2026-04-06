namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an equation with a base that contains a subscript.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub?view=word-pia"/>
public interface IOMathScrSub : IModelObject
{
  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub.e?view=word-pia"/>
  public IOMath E { get; }
  /// <summary>
  /// Returns the subscript expression.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub.sub?view=word-pia"/>
  public IOMath Sub { get; }

}
