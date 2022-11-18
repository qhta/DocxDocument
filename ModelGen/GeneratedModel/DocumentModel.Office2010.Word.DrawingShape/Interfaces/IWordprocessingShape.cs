namespace DocumentModel.Office2010.Word.DrawingShape;

/// <summary>
/// Defines the WordprocessingShape Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.INonVisualConnectorProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.INonVisualDrawingShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.ITextBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.ILinkedTextBox))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.DrawingShape.ITextBoxInfo2))]
public interface IWordprocessingShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// normalEastAsianFlow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NormalEastAsianFlow { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingShape.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
}
