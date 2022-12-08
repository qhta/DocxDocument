namespace DocumentModel.Drawings;

/// <summary>
/// Shape Definition.
/// </summary>
public class Shape1Impl: ModelElementImpl, Shape1
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public String? TextLink
  {
    get;
    set;
  }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  public Boolean? LockText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties7? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style3? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public TextBody3? TextBody
  {
    get;
    set;
  }
  
}
