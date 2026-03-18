namespace DocumentModel.Interop;

public partial interface SmartTagTypes
{
  /// <summary>
  /// Reloads all smart tag actions and recognizers installed on a user's computer.
  /// </summary>
  public void ReloadAll();
}
