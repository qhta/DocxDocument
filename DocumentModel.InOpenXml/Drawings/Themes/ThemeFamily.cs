namespace DocumentModel;

/// <summary>
/// Represents a theme family definition for Office documents, supporting identification, versioning, and extension metadata for advanced theme management scenarios.
/// </summary>
/// <remarks>
/// This interface provides properties for theme family name, unique identifiers, versioning, and OfficeArt extension metadata. It enables flexible theme organization, compatibility management, and extensibility for Office document processing and customization.
/// </remarks>
public class ThemeFamily: ModelElement
{
  /// <summary>
  /// Name of the theme family.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Unique identifier for the theme family.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  /// Version identifier for the theme family.
  /// </summary>
  public string? Vid { get; set; }

  /// <summary>
  /// OfficeArt extension metadata for the theme family.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}