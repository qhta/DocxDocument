namespace DocumentModel.Interop.Word;

public partial interface Broadcast
{
  /// <summary>
  /// Starts a broadcast session.
  /// </summary>
  /// <param name="serverUrl">The URL of the broadcast server.</param>
  public void Start(string serverUrl);
}
