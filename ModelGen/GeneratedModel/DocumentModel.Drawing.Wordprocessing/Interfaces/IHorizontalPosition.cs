namespace DocumentModel.Drawing.Wordprocessing;

public interface IHorizontalPosition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public HorizontalRelativePosition? RelativeFrom { get ; set; }

  public IHorizontalAlignment? HorizontalAlignment { get ; set; }

  public IPositionOffset? PositionOffset { get ; set; }

  public IPercentagePositionHeightOffset? PercentagePositionHeightOffset { get ; set; }

}
