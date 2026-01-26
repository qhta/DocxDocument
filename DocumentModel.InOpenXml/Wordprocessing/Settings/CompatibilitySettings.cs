namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of compatibility settings for a Wordprocessing document.
/// This class provides access to and management of <see cref = "CompatibilitySetting"/> elements, enabling advanced configuration and organization of compatibility options for document processing and rendering.
/// </summary>
[OpenXmlType(typeof(CompatibilitySetting))]
public class CompatibilitySettings : ElementCollection<CompatibilitySetting>
{
 protected override object? GetUpdatableOpenXmlElement()
 {
  throw new NotImplementedException();
 }
}