namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for an office style sheet, providing additional theme or formatting information.
/// </summary>
public class OfficeStyleSheetExtension: ModelElement<DXD.OfficeStyleSheetExtension>, IExtension
{

  /// <summary>
  ///   Theme family information associated with the extension.
  /// </summary>
  public ThemeFamily? ThemeFamily { get; set; }

  /// <summary>
  /// Uri string associated with the extension.
  /// </summary>
  public string? UriString { get; set; }
}