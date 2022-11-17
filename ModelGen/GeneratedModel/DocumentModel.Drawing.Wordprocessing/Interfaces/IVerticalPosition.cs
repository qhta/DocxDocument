namespace DocumentModel.Drawing.Wordprocessing;

public interface IVerticalPosition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public VerticalRelativePosition? RelativeFrom { get ; set; }
  
  public IVerticalAlignment? VerticalAlignment { get ; set; }
  
  public IPositionOffset? PositionOffset { get ; set; }
  
  public IPercentagePositionVerticalOffset? PercentagePositionVerticalOffset { get ; set; }
  
}
