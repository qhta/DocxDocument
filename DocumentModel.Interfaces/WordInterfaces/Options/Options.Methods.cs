namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface Options: InteropObject
{
  /// <summary>
  /// Returns the default path for the specified file type.
  /// </summary>
  /// <param name="Path">Specifies the default file path type.</param>
  /// <returns>The default file path.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.get_defaultfilepath?view=word-pia"/>
  public string DefaultFilePath(DefaultFilePath Path);

  /// <summary>
  /// Sets WordPerfect help and navigation option values.
  /// </summary>
  /// <param name="CommandKeyHelp">Specifies the command key help.</param>
  /// <param name="DocNavigationKeys">Specifies the doc navigation keys.</param>
  /// <param name="MouseSimulation">Specifies the mouse simulation.</param>
  /// <param name="DemoGuidance">Specifies the demo guidance.</param>
  /// <param name="DemoSpeed">Specifies the demo speed.</param>
  /// <param name="HelpType">Specifies the help type.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.setwphelpoptions?view=word-pia"/>
  public void SetWPHelpOptions(object CommandKeyHelp, object DocNavigationKeys, object MouseSimulation, object DemoGuidance, object DemoSpeed, object HelpType);
}
