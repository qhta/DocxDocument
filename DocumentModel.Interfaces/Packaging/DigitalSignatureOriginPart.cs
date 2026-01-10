namespace DocumentModel.Packaging;

/// <summary>
///   Defines the DigitalSignatureOriginPart
/// </summary>
public interface DigitalSignatureOriginPart: OpenXmlPart
{


  /// <summary>
  ///   Gets the XmlSignatureParts of the DigitalSignatureOriginPart
  /// </summary>
  public XmlSignatureParts XmlSignatureParts { get; set; }
}