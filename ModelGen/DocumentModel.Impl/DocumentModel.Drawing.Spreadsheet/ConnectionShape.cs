namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Connection Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Spreadsheet.INonVisualConnectionShapeProperties))]
public class ConnectionShape: IConnectionShape
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public string? Macro
  {
    get;
    set;
  }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Properties for a Connection Shape.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connector Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawing.Spreadsheet.IShapeStyle? ShapeStyle
  {
    get;
    set;
  }
  
}
