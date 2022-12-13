namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public interface AbstractNum
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  public Int32? AbstractNumberId { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public DocumentModel.HexWord? Nsid { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MultiLevelKind? MultiLevelType { get ; set; }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  public DocumentModel.HexWord? TemplateCode { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  public String? AbstractNumDefinitionName { get ; set; }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  public String? StyleLink { get ; set; }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  public String? NumberingStyleLink { get ; set; }
  
  public DocumentModel.Wordprocessing.Level? Level { get ; set; }
  
}
