namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualPictureProperties))]
public class Picture: IPicture
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
  /// Publish to Server
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualPictureProperties? NonVisualPictureProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IBlipFill? BlipFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IStyle? Style
  {
    get;
    set;
  }
  
}
