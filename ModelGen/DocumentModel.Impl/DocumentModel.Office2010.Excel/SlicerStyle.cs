namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISlicerStyleElements))]
public class SlicerStyle: ISlicerStyle
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlicerStyleElements.
  /// </summary>
  public ISlicerStyleElements? SlicerStyleElements
  {
    get;
    set;
  }
  
}
