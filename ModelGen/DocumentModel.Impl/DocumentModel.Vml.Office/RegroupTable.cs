namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Grouping History.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IEntry))]
public class RegroupTable: IRegroupTable
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension
  {
    get;
    set;
  }
  
}
