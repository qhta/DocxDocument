namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IListItem))]
public class SdtContentComboBox: ISdtContentComboBox
{
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public string? LastValue
  {
    get;
    set;
  }
  
}
