namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Shape Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.ITextBody))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualShapeProperties))]
public class Shape: IShape
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
  /// Text Link
  /// </summary>
  public string? TextLink
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  public bool? LockText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualShapeProperties? NonVisualShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IStyle? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.ITextBody? TextBody
  {
    get;
    set;
  }
  
}
