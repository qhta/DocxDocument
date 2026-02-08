namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of compatibility settings for a Wordprocessing document.
/// This class provides access to and management of <see cref = "CompatibilitySetting"/> elements, enabling advanced configuration and organization of compatibility options for document processing and rendering.
/// </summary>
public class OtherSettings : ModelElementCollection<CompatibilitySetting, DXW.Compatibility, DXW.CompatibilitySetting>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public OtherSettings()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="parent"></param>
  public OtherSettings(ModelElement parent) : base(parent) { }
}