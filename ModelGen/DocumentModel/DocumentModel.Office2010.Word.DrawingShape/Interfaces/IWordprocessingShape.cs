namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the WordprocessingShape Class.
/// </summary>
public interface IWordprocessingShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// normalEastAsianFlow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NormalEastAsianFlow { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
}
