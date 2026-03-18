namespace DocumentModel.Interop;

/// <summary>
/// Represents a single section in a selection, range, or document.
/// </summary>
public interface Section : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
  /// <summary>
  /// The page setup.
  /// </summary>
  public PageSetup PageSetup { get; set; }
  /// <summary>
  /// The headers.
  /// </summary>
  public HeadersFooters Headers { get; }
  /// <summary>
  /// The footers.
  /// </summary>
  public HeadersFooters Footers { get; }
  /// <summary>
  /// The protected for forms.
  /// </summary>
  public bool ProtectedForForms { get; set; }
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

}
