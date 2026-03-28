namespace DocumentModel.Interop;

public partial interface Conflicts
{
  /// <summary>
  /// Accepts all conflicts in the collection.
  /// </summary>
  public void AcceptAll();

  /// <summary>
  /// Rejects all conflicts in the collection.
  /// </summary>
  public void RejectAll();
}
