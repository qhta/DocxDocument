namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
public partial interface CustomXmlPart
{
  /// <summary>
  /// Gets the CustomXmlPropertiesPart of the CustomXmlPart
  /// </summary>
  public DocumentModel.Packaging.CustomXmlPropertiesPart? CustomXmlPropertiesPart { get; }
  
  public String? RelationshipType { get; }
  
}
