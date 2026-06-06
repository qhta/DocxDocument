namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a subscript.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub?view=word-pia"/>
public interface IMathScrSub : IInteropObject
{
  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub.e?view=word-pia"/>
  public IMath E { get; }
  /// <summary>
  /// Returns the subscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub.sub?view=word-pia"/>
  public IMath Sub { get; }

}


