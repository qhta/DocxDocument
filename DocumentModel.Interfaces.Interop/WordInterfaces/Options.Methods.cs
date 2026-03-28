namespace DocumentModel.Interop;

public partial interface Options
{
  /// <summary>
  /// Returns the default file path.
  /// </summary>
  /// <param name="Path">Specifies the path.</param>
  /// <returns>The resulting string value.</returns>
  public string get_DefaultFilePath(WdDefaultFilePath Path);

  /// <summary>
  /// Executes the set wphelp options operation.
  /// </summary>
  /// <param name="CommandKeyHelp">Specifies the command key help.</param>
  /// <param name="DocNavigationKeys">Specifies the doc navigation keys.</param>
  /// <param name="MouseSimulation">Specifies the mouse simulation.</param>
  /// <param name="DemoGuidance">Specifies the demo guidance.</param>
  /// <param name="DemoSpeed">Specifies the demo speed.</param>
  /// <param name="HelpType">Specifies the help type.</param>
  public void SetWPHelpOptions(object CommandKeyHelp, object DocNavigationKeys, object MouseSimulation, object DemoGuidance, object DemoSpeed, object HelpType);
}
