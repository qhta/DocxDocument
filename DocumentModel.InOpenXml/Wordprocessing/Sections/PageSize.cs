namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the page size settings for a section in a Wordprocessing document.
/// This interface provides properties for page width, height, orientation, printer paper code, and paper size, enabling advanced configuration of page layout and printing options.
/// </summary>
public interface PageSize : SectionPropertiesContent
{
  /// <summary>
  /// Page width, specified in twips.
  /// </summary>
  public Twips? Width { get; set; }

  /// <summary>
  /// Page height, specified in twips.
  /// </summary>
  public Twips? Height { get; set; }

  /// <summary>
  /// Page orientation, such as portrait or landscape.
  /// </summary>
  public PageOrientationKind? Orient { get; set; }

  /// <summary>
  /// Printer paper size, mapped from the printer paper code.
  /// </summary>
  public PaperSize? PaperSize { get; set; }

}