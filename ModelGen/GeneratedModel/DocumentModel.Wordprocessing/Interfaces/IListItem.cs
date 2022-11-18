namespace DocumentModel.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public interface IListItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  public string? DisplayText { get ; set; }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  public string? Value { get ; set; }
  
}
