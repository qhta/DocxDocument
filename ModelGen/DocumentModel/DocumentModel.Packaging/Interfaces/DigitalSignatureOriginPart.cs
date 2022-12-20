namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DigitalSignatureOriginPart
/// </summary>
public partial interface DigitalSignatureOriginPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
  /// <summary>
  /// Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  public Collection<DocumentModel.Packaging.XmlSignaturePart>? XmlSignatureParts { get; }
  
}
