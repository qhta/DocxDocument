namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a subscript.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub?view=word-pia"/>
public interface OMathScrSub : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The sub.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsub.sub?view=word-pia"/>
  public OMath Sub { get; }

}
