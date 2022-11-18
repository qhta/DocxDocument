namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LevelOverride Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStartOverrideNumberingValue))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevel))]
public interface ILevelOverride // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level ID
  /// </summary>
  public int? LevelIndex { get ; set; }
  
  /// <summary>
  /// Numbering Level Starting Value Override.
  /// </summary>
  public IStartOverrideNumberingValue? StartOverrideNumberingValue { get ; set; }
  
  /// <summary>
  /// Numbering Level Override Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.ILevel? Level { get ; set; }
  
}
