namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents header and footer configuration for printed chart output.
/// </summary>
/// <remarks>
///   This interface defines header and footer settings that control how
///   text appears at the top and bottom of printed chart pages. Headers and footers provide consistent page decoration
///   for printed charts, displaying information such as chart titles, page numbers, dates, author names, or other
///   contextual information that helps identify and organize printed output. The interface supports sophisticated
///   header/footer configurations including separate content for odd and even pages (<see cref="DifferentOddEven"/>),
///   distinct first-page headers/footers (<see cref="DifferentFirst"/>), and margin alignment options
///   (<see cref="AlignWithMargins"/>). This flexibility enables professional document formatting where headers and
///   footers can mirror each other on facing pages (for bound documents), provide special first-page treatment (such
///   as omitting headers on title pages), or align consistently with page margins. The header and footer content is
///   specified through string properties for different page scenarios: odd pages, even pages, and first page, with
///   separate properties for headers and footers in each case. These strings may contain plain text, formatting codes,
///   or field references that are resolved during printing. Header and footer configuration is referenced by
///   <see cref="PrintSettings"/> within the <see cref="ChartSpace"/>, controlling how charts appear when printed or
///   exported to print-oriented formats such as PDF. This configuration ensures that printed charts maintain consistent,
///   professional appearance with appropriate page decoration that aids in document organization and identification.
/// </remarks>
public interface HeaderFooter : IModelElement
{
  /// <summary>
  ///   Gets or sets a value indicating whether headers and footers align with the page margins.
  /// </summary>
  /// <remarks>
   ///   When enabled, headers and footers align with the left and right margins of the printed page, ensuring
  ///   consistent visual alignment between page content and header/footer content. This creates a cohesive appearance
  ///   where headers and footers respect the same page boundaries as the chart content. When disabled, headers and
  ///   footers may extend to the full width of the page, potentially extending beyond the content margins. Margin
  ///   alignment is typically preferred for professional documents where visual consistency and alignment are important,
  ///   ensuring that headers and footers don't appear disconnected from the main content.
  /// </remarks>
  public bool? AlignWithMargins { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether different headers and footers are used for odd and even pages.
  /// </summary>
  /// <remarks>
   ///   When enabled, odd-numbered pages use the content specified in <see cref="OddHeaderXsdString"/> and
  ///   <see cref="OddFooterXsdString"/>, while even-numbered pages use <see cref="EvenHeaderXsdString"/> and
  ///   <see cref="EvenFooterXsdString"/>. This feature is valuable for double-sided printing or bound documents
  ///   where facing pages should have mirrored headers and footers. For example, page numbers might appear on the
  ///   outer edge of each page (right side for odd pages, left side for even pages), or chapter titles might
  ///   alternate between left and right pages. When disabled, all pages use the odd page header/footer content,
  ///   providing consistent formatting throughout the document regardless of page number parity.
  /// </remarks>
  public bool? DifferentOddEven { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the first page uses different headers and footers.
  /// </summary>
  /// <remarks>
   ///   When enabled, the first page uses the content specified in <see cref="FirstHeaderXsdString"/> and
  ///   <see cref="FirstFooterXsdString"/>, while subsequent pages use the odd/even page content as appropriate.
  ///   This feature is commonly used to omit or customize headers and footers on title pages, cover pages, or
  ///   opening pages where standard header/footer content might be inappropriate or redundant. For example, a
  ///   title page might have no header and a minimal footer, while subsequent pages include full headers with
  ///   chart titles and footers with page numbers. When disabled, all pages including the first use the standard
  ///   odd/even page header/footer content.
  /// </remarks>
  public bool? DifferentFirst { get; set; }

  /// <summary>
  ///   Gets or sets the header content for odd-numbered pages.
  /// </summary>
  /// <remarks>
  ///   The odd header string defines the content that appears at the top of odd-numbered pages when the chart is
  ///   printed. This string may contain plain text, formatting codes for styling (such as bold, italic, or font
  ///   changes), field codes that are dynamically replaced during printing (such as page numbers, dates, or chart
  ///   names), and alignment indicators that position content at the left, center, or right of the header area.
  ///   When <see cref="DifferentOddEven"/> is disabled, this header content is used for all pages. When enabled,
  ///   it applies only to odd-numbered pages, with even pages using <see cref="EvenHeaderXsdString"/>. The first
  ///   page uses this content unless <see cref="DifferentFirst"/> is enabled, in which case it uses
  ///   <see cref="FirstHeaderXsdString"/>.
  /// </remarks>
  public string? OddHeaderXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the footer content for odd-numbered pages.
  /// </summary>
  /// <remarks>
  ///   The odd footer string defines the content that appears at the bottom of odd-numbered pages when the chart is
  ///   printed. This string may contain plain text, formatting codes, field codes, and alignment indicators similar
  ///   to header strings. Common footer content includes page numbers (often formatted as "Page X of Y"), copyright
  ///   notices, document identifiers, or dates. When <see cref="DifferentOddEven"/> is disabled, this footer content
  ///   is used for all pages. When enabled, it applies only to odd-numbered pages, with even pages using
  ///   <see cref="EvenFooterXsdString"/>. The first page uses this content unless <see cref="DifferentFirst"/> is
  ///   enabled, in which case it uses <see cref="FirstFooterXsdString"/>.
  /// </remarks>
  public string? OddFooterXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the header content for even-numbered pages.
  /// </summary>
  /// <remarks>
  ///   The even header string defines the content that appears at the top of even-numbered pages when the chart is
  ///   printed. This content is only used when <see cref="DifferentOddEven"/> is enabled; otherwise, even pages use
  ///   <see cref="OddHeaderXsdString"/>. Even page headers often mirror odd page headers with content positioned
  ///   differently to create a balanced appearance on facing pages. For example, if odd page headers show the chart
  ///   title on the right, even page headers might show it on the left, creating visual symmetry in bound documents.
  ///   The header string format supports the same text, formatting codes, field codes, and alignment indicators as
  ///   odd page headers.
  /// </remarks>
  public string? EvenHeaderXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the footer content for even-numbered pages.
  /// </summary>
  /// <remarks>
  ///   The even footer string defines the content that appears at the bottom of even-numbered pages when the chart is
  ///   printed. This content is only used when <see cref="DifferentOddEven"/> is enabled; otherwise, even pages use
  ///   <see cref="OddFooterXsdString"/>. Even page footers typically mirror odd page footers with adjusted positioning
  ///   to maintain visual balance on facing pages. For example, page numbers might appear on the outer edge of each
  ///   page, requiring different alignment for odd and even pages. The footer string format supports the same text,
  ///   formatting codes, field codes, and alignment indicators as odd page footers.
  /// </remarks>
  public string? EvenFooterXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the header content for the first page.
  /// </summary>
  /// <remarks>
  ///   The first header string defines the content that appears at the top of the first page when the chart is printed.
  ///   This content is only used when <see cref="DifferentFirst"/> is enabled; otherwise, the first page uses the
  ///   standard odd page header (<see cref="OddHeaderXsdString"/>). First page headers are commonly used to provide
  ///   special treatment for title pages or cover pages, often being left blank or containing minimal content that
  ///   differs from subsequent pages. For example, a first page might have no header to avoid competing with a large
  ///   title, while subsequent pages include headers with chart or section names. The header string format supports
  ///   the same text, formatting codes, field codes, and alignment indicators as other page headers.
  /// </remarks>
  public string? FirstHeaderXsdString { get; set; }

  /// <summary>
  ///   Gets or sets the footer content for the first page.
  /// </summary>
  /// <remarks>
  ///   The first footer string defines the content that appears at the bottom of the first page when the chart is
  ///   printed. This content is only used when <see cref="DifferentFirst"/> is enabled; otherwise, the first page
  ///   uses the standard odd page footer (<see cref="OddFooterXsdString"/>). First page footers are commonly
  ///   customized to provide appropriate information for title or cover pages, perhaps omitting page numbers that
  ///   would normally start from page 2, or including copyright or attribution information specific to the title
  ///   page. The footer string format supports the same text, formatting codes, field codes, and alignment indicators
  ///   as other page footers.
  /// </remarks>
  public string? FirstFooterXsdString { get; set; }
}