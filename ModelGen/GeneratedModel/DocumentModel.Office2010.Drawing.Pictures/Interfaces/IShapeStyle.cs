namespace DocumentModel.Office2010.Drawing.Pictures;

public interface IShapeStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }
  
  public DocumentModel.Drawing.IFillReference? FillReference { get ; set; }
  
  public DocumentModel.Drawing.IEffectReference? EffectReference { get ; set; }
  
  public DocumentModel.Drawing.IFontReference? FontReference { get ; set; }
  
}
