namespace DocumentModel.Drawings;

/// <summary>
///   Represents an element that supports extensibility for office style sheets through an extension list.
/// </summary>
public interface IOfficeStyleSheetExtendableElement
{
  /// <summary>
  ///   List of extension elements for the office style sheet.
  /// </summary>
  public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get; set; }
}