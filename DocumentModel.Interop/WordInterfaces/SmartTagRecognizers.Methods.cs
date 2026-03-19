namespace DocumentModel.Interop.Word;

public partial interface SmartTagRecognizers
{
  /// <summary>
  /// Reloads all recognizers installed on a user's computer.
  /// </summary>
  public void ReloadRecognizers();
}
