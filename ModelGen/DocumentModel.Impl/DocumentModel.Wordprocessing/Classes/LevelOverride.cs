namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public class LevelOverrideImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.LevelOverride>, LevelOverride
{
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public Level? Level
  {
    get;
    set;
  }
  
}
