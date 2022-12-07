namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public interface AbstractNum
{
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public DocumentModel.HexWord? Nsid { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public MultiLevelKind? MultiLevelType { get ; set; }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  public DocumentModel.HexWord? TemplateCode { get ; set; }
  
}
