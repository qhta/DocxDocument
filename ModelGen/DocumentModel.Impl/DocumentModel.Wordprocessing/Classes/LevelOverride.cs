namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public class LevelOverrideImpl: ModelElementImpl, LevelOverride
{
  public DocumentFormat.OpenXml.Wordprocessing.LevelOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LevelOverride?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public Int32? LevelIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public Int32? StartOverrideNumberingValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public Level? Level
  {
    get;
    set;
  }
  
}
