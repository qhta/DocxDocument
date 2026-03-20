
namespace DocumentModel.Interop.Core;

public partial interface IMsoAxis
{
  public bool AxisBetweenCategories { get; set; }
  public XlAxisGroup AxisGroup { get; }
  public IMsoAxisTitle AxisTitle { get; }
  public object CategoryNames { get; set; }
  public XlAxisCrosses Crosses { get; set; }
  public double CrossesAt { get; set; }
  public bool HasMajorGridlines { get; set; }
  public bool HasMinorGridlines { get; set; }
  public bool HasTitle { get; set; }
  public GridLines MajorGridlines { get; }
  public XlTickMark MajorTickMark { get; set; }
  public double MajorUnit { get; set; }
  public double LogBase { get; set; }
  public bool TickLabelSpacingIsAuto { get; set; }
  public bool MajorUnitIsAuto { get; set; }
  public double MaximumScale { get; set; }
  public bool MaximumScaleIsAuto { get; set; }
  public double MinimumScale { get; set; }
  public bool MinimumScaleIsAuto { get; set; }
  public GridLines MinorGridlines { get; }
  public XlTickMark MinorTickMark { get; set; }
  public double MinorUnit { get; set; }
  public bool MinorUnitIsAuto { get; set; }
  public bool ReversePlotOrder { get; set; }
  public XlScaleType ScaleType { get; set; }
  public XlTickLabelPosition TickLabelPosition { get; set; }
  public IMsoTickLabels TickLabels { get; }
  public int TickLabelSpacing { get; set; }
  public int TickMarkSpacing { get; set; }
  public XlAxisType Type { get; set; }
  public XlTimeUnit BaseUnit { get; set; }
  public bool BaseUnitIsAuto { get; set; }
  public XlTimeUnit MajorUnitScale { get; set; }
  public XlTimeUnit MinorUnitScale { get; set; }
  public XlCategoryType CategoryType { get; set; }
  public double Left { get; }
  public double Top { get; }
  public double Width { get; }
  public double Height { get; }
  public XlDisplayUnit DisplayUnit { get; set; }
  public double DisplayUnitCustom { get; set; }
  public bool HasDisplayUnitLabel { get; set; }
  public IMsoDisplayUnitLabel DisplayUnitLabel { get; }
  public IMsoBorder Border { get; }
  public string Name { get; }
  public IMsoChartFormat Format { get; }
}
