namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DigitalSignatureOriginPart
/// </summary>
public class DigitalSignatureOriginPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  public Collection<XmlSignaturePart>? XmlSignatureParts { get; set; }
}