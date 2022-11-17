namespace DocumentModel.Drawing.Charts;

public interface IChartText // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IStringReference? StringReference { get ; set; }

  public IRichText? RichText { get ; set; }

  public IStringLiteral? StringLiteral { get ; set; }

}
