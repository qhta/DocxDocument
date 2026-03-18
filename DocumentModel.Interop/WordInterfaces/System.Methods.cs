namespace DocumentModel.Interop;

public partial interface System
{
  /// <summary>
  /// Returns the profile string.
  /// </summary>
  /// <param name="Section">Specifies the section.</param>
  /// <param name="Key">Specifies the key.</param>
  /// <returns>The resulting string value.</returns>
  public string ProfileString(string Section, string Key);

  /// <summary>
  /// Starts the Microsoft System Information application if it's not running, or switches to it if it's already running.
  /// </summary>
  public void MSInfo();
}
