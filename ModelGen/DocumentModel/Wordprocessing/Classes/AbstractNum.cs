namespace DocumentModel.Wordprocessing;


/// <summary>
///   Abstract Numbering Definition.
/// </summary>
public partial class AbstractNum
{
  
  /// <summary>
  ///   Abstract Numbering Definition ID
  /// </summary>
  public HexInt? AbstractNumberId { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Identifier.
  /// </summary>
  public UInt32? Nsid { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  public MultiLevelKind? MultiLevelType { get; set; }
  
  
  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  public UInt32? TemplateCode { get; set; }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Name.
  /// </summary>
  public String? AbstractNumDefinitionName { get; set; }
  
  
  /// <summary>
  ///   Numbering Style Definition.
  /// </summary>
  public String? StyleLink { get; set; }
  
  
  /// <summary>
  ///   Numbering Style Reference.
  /// </summary>
  public String? NumberingStyleLink { get; set; }
  
  public ElementCollection<Level>? Items { get; set; }
  
}
