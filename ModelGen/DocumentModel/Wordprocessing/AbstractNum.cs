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
  public DMW.Nsid? Nsid { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  public DMW.MultiLevelKind? MultiLevelType { get; set; }
  
  
  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  public DMW.TemplateCode? TemplateCode { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Name.
  /// </summary>
  public DMW.AbstractNumDefinitionName? AbstractNumDefinitionName { get; set; }
  
  
  /// <summary>
  ///   Numbering Style Definition.
  /// </summary>
  public DMW.StyleLink? StyleLink { get; set; }
  
  
  /// <summary>
  ///   Numbering Style Reference.
  /// </summary>
  public DMW.NumberingStyleLink? NumberingStyleLink { get; set; }
  
}
