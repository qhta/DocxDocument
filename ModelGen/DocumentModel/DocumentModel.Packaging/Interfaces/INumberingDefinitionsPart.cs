namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NumberingDefinitionsPart
/// </summary>
public interface INumberingDefinitionsPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public IEnumerable<DocumentFormat.OpenXml.Packaging.ImagePart>? ImageParts { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public INumbering? Numbering { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
