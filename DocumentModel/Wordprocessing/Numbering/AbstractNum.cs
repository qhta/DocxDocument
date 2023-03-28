namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies a set of properties which shall dictate the appearance and behavior of a set of numbered paragraphs. 
///   These properties are collectively called an abstract numbering definition, 
///   and are the basis for all numbering information in a WordprocessingML document.
///   Although an abstract numbering definition contains a complete set of numbering, it shall not be directly referenced by content 
///   (hence the use of abstract). Instead, these properties shall be inherited by a numbering definition instance using the num element, 
///   which can then itself be referenced by content.
/// </summary>
public class AbstractNum : ModelElement
{
  /// <summary>
  ///   Specifies a unique number which shall be used as the identifier for this abstract numbering definition. 
  ///   This unique number shall be referenced by any numbering definition instance 
  ///   in order to inherit the properties specified by this abstract numbering definition.
  /// </summary>
  public Int32? AbstractNumberId { get; set; }

  /// <summary>
  ///   Associates a unique hexadecimal ID to the abstract numbering definition. 
  ///   This number shall be identical for two abstract numbering definitions that are based from the same initial numbering definition 
  ///   - if a document is repurposed and the underlying numbering definition is changed, it shall maintain its original nsid.
  /// </summary>
  public HexInt? Nsid { get; set; }

  /// <summary>
  ///   Apecifies the type of numbering defined by a given abstract numbering type. 
  ///   This information shall only be used by a consumer to determine user interface behaviors for this numbering definition, 
  ///   and shall not be used to limit the behavior of the list 
  ///   (i.e. a list with multiple levels marked as singleLevel shall not be prevented from using levels 2 through 9).
  /// </summary>
  public MultiLevelKind? MultiLevelType { get; set; }

  /// <summary>
  ///   Specifies the name of a given abstract numbering definition. 
  ///   This name can be surfaced in order to provide a user friendly alias for a given numbering definition, 
  ///   but shall not influence the behavior of the list - two identical definitions with different name elements shall behave identically.
  /// </summary>
  public string? AbstractNumDefinitionName { get; set; }

  /// <summary>
  ///   Specifies a unique hexadecimal code which can be used to determine a location within application user interface 
  ///   in which this abstract numbering definition shall be displayed.
  /// </summary>
  public HexInt? TemplateCode { get; set; }
  
  /// <summary>
  ///    Specifies that the parent abstract numbering definition is the base numbering definition 
  ///    for the specified numbering style referenced in its val attribute.
  /// </summary>
  public string? StyleLink { get; set; }

  /// <summary>
  ///   Specifies an abstract numbering that does not contain the actual numbering properties for its numbering type, 
  ///   but rather serves as a reference to a numbering style stored in the document, 
  ///   which shall be applied when this abstract numbering definition is referenced, 
  ///   and itself points at the actual underlying abstract numbering definition to be used.  /// </summary>
  public string? NumberingStyleLink { get; set; }

  /// <summary>
  ///   Definitions of abstract numbering levels.
  /// </summary>
  [XmlContentElement] public NumLevels? Levels { get; set; }
}