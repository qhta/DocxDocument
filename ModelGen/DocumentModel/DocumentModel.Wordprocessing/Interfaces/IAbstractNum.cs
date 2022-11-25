namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public interface IAbstractNum // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  public System.Int32? AbstractNumberId { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public DocumentModel.BaseTypes.HexWord? Nsid { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public DocumentModel.Wordprocessing.MultiLevelKind? MultiLevelType { get ; set; }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  public DocumentModel.BaseTypes.HexWord? TemplateCode { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  public System.String? AbstractNumDefinitionName { get ; set; }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  public System.String? StyleLink { get ; set; }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  public System.String? NumberingStyleLink { get ; set; }
  
}
