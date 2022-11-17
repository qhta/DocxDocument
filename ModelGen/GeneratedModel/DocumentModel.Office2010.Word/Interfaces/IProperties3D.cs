namespace DocumentModel.Office2010.Word;

public interface IProperties3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public long? ExtrusionHeight { get ; set; }
  
  public long? ContourWidth { get ; set; }
  
  public DocumentModel.Office2010.Word.PresetMaterialType? PresetMaterialType { get ; set; }
  
  public DocumentModel.Office2010.Word.IBevelTop? BevelTop { get ; set; }
  
  public DocumentModel.Office2010.Word.IBevelBottom? BevelBottom { get ; set; }
  
  public DocumentModel.Office2010.Word.IExtrusionColor? ExtrusionColor { get ; set; }
  
  public DocumentModel.Office2010.Word.IContourColor? ContourColor { get ; set; }
  
}
