namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow?view=word-pia"/>
public partial interface IProtectedViewWindow: IModelObject
{
  /// <summary>
  /// Activates the specified protected view window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.activate?view=word-pia"/>
  public void Activate();
}
