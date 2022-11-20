namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the AxisUnits Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAxisUnitsLabel))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
public class AxisUnits: IAxisUnits
{
  /// <summary>
  /// unit, this property is only available in Office 2016 and later.
  /// </summary>
  public AxisUnit? Unit
  {
    get;
    set;
  }
  
  /// <summary>
  /// AxisUnitsLabel.
  /// </summary>
  public IAxisUnitsLabel? AxisUnitsLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
