namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public interface ILevelOverride // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public Int32? LevelIndex { get ; set; }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public IStartOverrideNumberingValue? StartOverrideNumberingValue { get ; set; }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public ILevel? Level { get ; set; }
  
}
