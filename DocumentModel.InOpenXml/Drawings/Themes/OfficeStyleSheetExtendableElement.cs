namespace DocumentModel.Drawings;

/// <summary>
///   Represents an element that supports extensibility for office style sheets through an extension list.
/// </summary>
public interface OfficeStyleSheetExtendableElement
{
  /// <summary>
  ///   List of extension elements for the office style sheet.
  /// </summary>
  public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get; set; }
}