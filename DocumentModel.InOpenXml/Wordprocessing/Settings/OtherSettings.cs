namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of compatibility settings for a Wordprocessing document.
/// This class provides access to and management of <see cref = "CompatibilitySetting"/> elements, enabling advanced configuration and organization of compatibility options for document processing and rendering.
/// </summary>
[XmlRoot("OtherSettings", Namespace = "DocumentModel.Wordprocessing")]
public class OtherSettings : ModelElementCollection<CompatibilitySetting, DXW.Compatibility, DXW.CompatibilitySetting>
{
  /// <summary>
  /// Default constructor for the OtherSettings class, initializing a new instance of the OtherSettings class with default compatibility settings.
  /// </summary>
  public OtherSettings() : base(new DXW.Compatibility()) { }

  /// <summary>
  /// Initializes a new instance of the OtherSettings class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that contains this OtherSettings instance. Cannot be null.</param>
  public OtherSettings(ModelElement parent) : base(parent) { }

  /// <summary>
  /// Initializes a new instance of the OtherSettings class using the specified compatibility options.
  /// </summary>
  /// <param name="compatibility">The compatibility options to use for configuring the settings. Cannot be null.</param>
  public OtherSettings(DXW.Compatibility compatibility) : base(compatibility) { }
}