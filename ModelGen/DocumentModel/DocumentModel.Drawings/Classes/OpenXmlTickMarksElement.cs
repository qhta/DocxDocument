namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public class OpenXmlTickMarksElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public TickMarksType? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
