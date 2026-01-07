namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for an office style sheet, providing additional theme or formatting information.
/// </summary>
public interface OfficeStyleSheetExtension
{
  /// <summary>
  ///   Uniform Resource Identifier for the extension.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  ///   Theme family information associated with the extension.
  /// </summary>
  public ThemeFamily? ThemeFamily { get; set; }
}