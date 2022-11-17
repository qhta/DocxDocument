namespace DocumentModel.Drawing.Wordprocessing;

public interface IWrapPolygon // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Edited { get ; set; }
  
  public IStartPoint? StartPoint { get ; set; }
  
}
