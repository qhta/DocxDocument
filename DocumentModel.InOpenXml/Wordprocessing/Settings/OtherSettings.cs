namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of compatibility settings for a Wordprocessing document.
/// This class provides access to and management of <see cref = "CompatibilitySetting"/> elements, enabling advanced configuration and organization of compatibility options for document processing and rendering.
/// </summary>
[XmlRoot("OtherSettings", Namespace = "DocumentModel.Wordprocessing")]
public class OtherSettings : ModelElementCollection<CompatibilitySetting, DXW.Compatibility, DXW.CompatibilitySetting>
{

  /// <summary>
  /// Default constructor for the OtherSettings class, initializing a new instance without any parent element or underlying OpenXml element.
  /// </summary>
  public OtherSettings(): base() { }

  /// <summary>
  /// Initializes a new instance of the OtherSettings class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this OtherSettings instance. Cannot be null.</param>
  /// <param name="openXmlElement">The OpenXml element that represents the compatibility settings. Can be null.</param>
  public OtherSettings(ModelElement parent, DXW.Compatibility? openXmlElement) : base(parent, openXmlElement) { }

}