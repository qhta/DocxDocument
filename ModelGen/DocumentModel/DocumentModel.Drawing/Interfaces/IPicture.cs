namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public interface IPicture // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public System.String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public System.Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Style.
  /// </summary>
  public DocumentModel.Drawing.IStyle? Style { get ; set; }
  
}
