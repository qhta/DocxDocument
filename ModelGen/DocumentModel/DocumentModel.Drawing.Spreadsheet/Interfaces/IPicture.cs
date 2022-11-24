namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public interface IPicture // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Reference To Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Picture.
  /// </summary>
  public INonVisualPictureProperties? NonVisualPictureProperties { get ; set; }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public IBlipFill? BlipFill { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
}
