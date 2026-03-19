namespace DocumentModel.Interop.Word;

public partial interface CoAuthLock
{
  /// <summary>
  /// Releases the co-authoring lock.
  /// </summary>
  public void Unlock();
}
