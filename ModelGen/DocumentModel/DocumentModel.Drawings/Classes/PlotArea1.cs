namespace DocumentModel.Drawings;

/// <summary>
/// Plot data and formatting.
/// </summary>
public class PlotArea1
{
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout1? Layout
  {
    get;
    set;
  }
  
  public DataTable? DataTable
  {
    get;
    set;
  }
  
  public ShapeProperties1? ShapeProperties
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
