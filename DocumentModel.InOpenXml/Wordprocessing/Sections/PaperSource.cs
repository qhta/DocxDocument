namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the paper source settings for a section in a Wordprocessing document.
/// This class provides properties for specifying printer tray codes for the first page and non-first pages, enabling advanced configuration of paper source selection during printing.
/// </summary>
public class PaperSource : ModelElement<DXW.PaperSource>, ISectionPropertiesContent
{
  /// <summary>
  /// Printer tray code for the first page.
  /// </summary>
  public UInt16? First { get; set; }

  /// <summary>
  /// Printer tray code for non-first pages.
  /// </summary>
  public UInt16? Other { get; set; }
}