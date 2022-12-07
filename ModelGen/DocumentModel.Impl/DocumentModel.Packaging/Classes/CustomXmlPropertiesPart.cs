namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public class CustomXmlPropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, CustomXmlPropertiesPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem
  {
    get;
    set;
  }
  
}
