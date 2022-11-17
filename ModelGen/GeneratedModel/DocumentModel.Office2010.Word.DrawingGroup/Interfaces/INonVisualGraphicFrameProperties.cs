namespace DocumentModel.Office2010.Word.DrawingGroup;

public interface INonVisualGraphicFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IGraphicFrameLocks? GraphicFrameLocks { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
