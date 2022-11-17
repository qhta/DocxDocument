namespace DocumentModel.Drawing;

public interface IShape3DType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public long? Z { get ; set; }
  
  public long? ExtrusionHeight { get ; set; }
  
  public long? ContourWidth { get ; set; }
  
  public DocumentModel.Drawing.PresetMaterialType? PresetMaterial { get ; set; }
  
  public DocumentModel.Drawing.IBevelTop? BevelTop { get ; set; }
  
  public DocumentModel.Drawing.IBevelBottom? BevelBottom { get ; set; }
  
  public DocumentModel.Drawing.IExtrusionColor? ExtrusionColor { get ; set; }
  
  public DocumentModel.Drawing.IContourColor? ContourColor { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
