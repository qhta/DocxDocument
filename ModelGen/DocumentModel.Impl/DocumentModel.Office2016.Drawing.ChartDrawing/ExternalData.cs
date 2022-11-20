namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public class ExternalData: IExternalData
{
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? AutoUpdate
  {
    get;
    set;
  }
  
}
