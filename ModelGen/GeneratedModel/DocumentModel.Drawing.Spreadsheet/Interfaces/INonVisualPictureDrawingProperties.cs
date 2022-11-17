namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualPictureDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? PreferRelativeResize { get ; set; }
  
  public IPictureLocks? PictureLocks { get ; set; }
  
  public INonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get ; set; }
  
}
