namespace DocumentModel.Interop;

public partial interface IApplicationEvents
{
  /// <summary>
  /// Occurs when the application starts up.
  /// </summary>
  public void Startup();

  /// <summary>
  /// Occurs when the application is quitting.
  /// </summary>
  public void Quit();

  /// <summary>
  /// Occurs when the active document changes.
  /// </summary>
  public void DocumentChange();
}
