namespace DocumentModel.Math;

public interface IEquationArrayProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IBaseJustification? BaseJustification { get ; set; }

  public IMaxDistribution? MaxDistribution { get ; set; }

  public IObjectDistribution? ObjectDistribution { get ; set; }

  public IRowSpacingRule? RowSpacingRule { get ; set; }

  public IRowSpacing? RowSpacing { get ; set; }

  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }

}
