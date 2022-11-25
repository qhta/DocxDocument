namespace DocumentModel.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public interface IListItem // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  public System.String? DisplayText { get ; set; }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  public System.String? Value { get ; set; }
  
}
