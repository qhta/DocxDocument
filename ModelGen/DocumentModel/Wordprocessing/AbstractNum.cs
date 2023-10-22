namespace DocumentModel.Wordprocessing;


/// <summary>
///   Abstract Numbering Definition.
/// </summary>
public partial class AbstractNum
{
  
  /// <summary>
  ///   Abstract Numbering Definition ID
  /// </summary>
  public Int32? AbstractNumberId { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Identifier.
  /// </summary>
  public DocumentModel.Wordprocessing.Nsid? Nsid { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MultiLevelKind? MultiLevelType { get; set; }
  
  
  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  public DocumentModel.Wordprocessing.TemplateCode? TemplateCode { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Name.
  /// </summary>
  public DocumentModel.Wordprocessing.AbstractNumDefinitionName? AbstractNumDefinitionName { get; set; }
  
  
  /// <summary>
  ///   Numbering Style Definition.
  /// </summary>
  public DocumentModel.Wordprocessing.StyleLink? StyleLink { get; set; }
  
  
  /// <summary>
  ///   Numbering Style Reference.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingStyleLink? NumberingStyleLink { get; set; }
  
}
