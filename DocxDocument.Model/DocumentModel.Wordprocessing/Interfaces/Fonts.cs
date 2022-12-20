namespace DocumentModel.Wordprocessing;

/// <summary>
/// Font Table Root Element.
/// </summary>
public partial interface Fonts
{
  /// <summary>
  /// Gets the FontTablePart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.FontTablePart? FontTablePart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.Font>? Items { get; set; }
  
}
