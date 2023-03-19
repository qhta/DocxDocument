namespace DocumentModel.Wordprocessing;

/// <summary>
///   Abstract Numbering Definition.
/// </summary>
public class AbstractNum: ModelElement
{
  /// <summary>
  ///   Abstract Numbering Definition ID
  /// </summary>
  public Int32? AbstractNumberId { get; set; }

  /// <summary>
  ///   Abstract Numbering Definition Identifier.
  /// </summary>
  public HexInt? Nsid { get; set; }

  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  public MultiLevelKind? MultiLevelType { get; set; }

  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  public HexInt? TemplateCode { get; set; }

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

  public Collection<Level>? Levels { get; set; }
}