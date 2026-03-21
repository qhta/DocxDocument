namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.iapplicationevents?view=word-pia"/>
public partial interface IApplicationEvents
{
  /// <summary>
  /// Occurs when the application starts up.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.iapplicationevents.startup?view=word-pia"/>
  public void Startup();

  /// <summary>
  /// Occurs when the application is quitting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.iapplicationevents.quit?view=word-pia"/>
  public void Quit();

  /// <summary>
  /// Occurs when the active document changes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.iapplicationevents.documentchange?view=word-pia"/>
  public void DocumentChange();
}
