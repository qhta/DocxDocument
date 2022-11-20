namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INsid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITemplateCode))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevel))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMultiLevelType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAbstractNumDefinitionName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStyleLink))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INumberingStyleLink))]
public interface IAbstractNum // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Abstract Numbering Definition ID
  /// </summary>
  public int? AbstractNumberId { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Identifier.
  /// </summary>
  public INsid? Nsid { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public IMultiLevelType? MultiLevelType { get ; set; }
  
  /// <summary>
  /// Numbering Template Code.
  /// </summary>
  public ITemplateCode? TemplateCode { get ; set; }
  
  /// <summary>
  /// Abstract Numbering Definition Name.
  /// </summary>
  public IAbstractNumDefinitionName? AbstractNumDefinitionName { get ; set; }
  
  /// <summary>
  /// Numbering Style Definition.
  /// </summary>
  public IStyleLink? StyleLink { get ; set; }
  
  /// <summary>
  /// Numbering Style Reference.
  /// </summary>
  public INumberingStyleLink? NumberingStyleLink { get ; set; }
  
}
