namespace DocumentModel.Math;

public interface IGroupCharProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IAccentChar? AccentChar { get ; set; }
  
  public DocumentModel.Math.IPosition? Position { get ; set; }
  
  public IVerticalJustification? VerticalJustification { get ; set; }
  
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
