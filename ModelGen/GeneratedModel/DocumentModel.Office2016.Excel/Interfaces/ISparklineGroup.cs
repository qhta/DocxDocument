namespace DocumentModel.Office2016.Excel;

public interface ISparklineGroup // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public double? ManualMax { get ; set; }

  public double? ManualMin { get ; set; }

  public double? LineWeight { get ; set; }

  public SparklineType? Type { get ; set; }

  public bool? DateAxis { get ; set; }

  public DocumentModel.Office2010.Excel.DisplayBlanksAs? DisplayEmptyCellsAs { get ; set; }

  public bool? Markers { get ; set; }

  public bool? High { get ; set; }

  public bool? Low { get ; set; }

  public bool? First { get ; set; }

  public bool? Last { get ; set; }

  public bool? Negative { get ; set; }

  public bool? DisplayXAxis { get ; set; }

  public bool? DisplayHidden { get ; set; }

  public SparklineAxisMinMax? MinAxisType { get ; set; }

  public SparklineAxisMinMax? MaxAxisType { get ; set; }

  public bool? RightToLeft { get ; set; }

  public ISeriesColor? SeriesColor { get ; set; }

  public INegativeColor? NegativeColor { get ; set; }

  public IAxisColor? AxisColor { get ; set; }

  public IMarkersColor? MarkersColor { get ; set; }

  public IFirstMarkerColor? FirstMarkerColor { get ; set; }

  public ILastMarkerColor? LastMarkerColor { get ; set; }

  public IHighMarkerColor? HighMarkerColor { get ; set; }

  public ILowMarkerColor? LowMarkerColor { get ; set; }

  public DocumentModel.Office.Excel.IFormula? Formula { get ; set; }

  public ISparklines? Sparklines { get ; set; }

}
