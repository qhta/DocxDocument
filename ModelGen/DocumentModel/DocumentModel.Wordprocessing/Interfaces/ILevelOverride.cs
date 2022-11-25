namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
public interface ILevelOverride // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public System.Int32? LevelIndex { get ; set; }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public System.Int32? StartOverrideNumberingValue { get ; set; }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.ILevel? Level { get ; set; }
  
}
