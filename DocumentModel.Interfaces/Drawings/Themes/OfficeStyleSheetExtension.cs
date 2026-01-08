namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for an office style sheet, providing additional theme or formatting information.
/// </summary>
public interface OfficeStyleSheetExtension: Extension
{

  /// <summary>
  ///   Theme family information associated with the extension.
  /// </summary>
  public ThemeFamily? ThemeFamily { get; set; }
}