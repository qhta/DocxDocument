namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public class DataLabelHidden: IDataLabelHidden
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Idx
  {
    get;
    set;
  }
  
}
