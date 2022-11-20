namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IListItem))]
public class SdtContentDropDownList: ISdtContentDropDownList
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public string? LastValue
  {
    get;
    set;
  }
  
}
