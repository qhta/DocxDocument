namespace DocumentModel.Drawing.Wordprocessing;

public interface INonVisualGraphicFrameDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IGraphicFrameLocks? GraphicFrameLocks { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
