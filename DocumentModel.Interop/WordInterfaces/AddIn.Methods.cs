namespace DocumentModel.Interop.Word;

public partial interface AddIn
{
  /// <summary>
  /// Deletes the add-in from the list of available add-ins.
  /// </summary>
  public void Delete();
}
