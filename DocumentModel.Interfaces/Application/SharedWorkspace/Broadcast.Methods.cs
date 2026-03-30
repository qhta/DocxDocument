namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast?view=word-pia"/>
public partial interface IBroadcast: IModelObject
{
  /// <summary>
  /// Starts a broadcast session.
  /// </summary>
  /// <param name="serverUrl">The URL of the broadcast server.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.start?view=word-pia"/>
  public void Start(string serverUrl);
}
