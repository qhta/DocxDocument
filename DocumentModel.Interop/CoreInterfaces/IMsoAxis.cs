
namespace DocumentModel.Interop.Core;

public interface IMsoAxis
{
  bool AxisBetweenCategories { get; set; }
  XlAxisGroup AxisGroup { get; }
  IMsoAxisTitle AxisTitle { get; }
  object CategoryNames { get; set; }
  XlAxisCrosses Crosses { get; set; }
  double CrossesAt { get; set; }
  object Delete();
  bool HasMajorGridlines { get; set; }
  bool HasMinorGridlines { get; set; }
  bool HasTitle { get; set; }
  GridLines MajorGridlines { get; }
  XlTickMark MajorTickMark { get; set; }
  double MajorUnit { get; set; }
  double LogBase { get; set; }
  bool TickLabelSpacingIsAuto { get; set; }
  bool MajorUnitIsAuto { get; set; }
  double MaximumScale { get; set; }
  bool MaximumScaleIsAuto { get; set; }
  double MinimumScale { get; set; }
  bool MinimumScaleIsAuto { get; set; }
  GridLines MinorGridlines { get; }
  XlTickMark MinorTickMark { get; set; }
  double MinorUnit { get; set; }
  bool MinorUnitIsAuto { get; set; }
  bool ReversePlotOrder { get; set; }
  XlScaleType ScaleType { get; set; }
  object Select();
  XlTickLabelPosition TickLabelPosition { get; set; }
  IMsoTickLabels TickLabels { get; }
  int TickLabelSpacing { get; set; }
  int TickMarkSpacing { get; set; }
  XlAxisType Type { get; set; }
  XlTimeUnit BaseUnit { get; set; }
  bool BaseUnitIsAuto { get; set; }
  XlTimeUnit MajorUnitScale { get; set; }
  XlTimeUnit MinorUnitScale { get; set; }
  XlCategoryType CategoryType { get; set; }
  double Left { get; }
  double Top { get; }
  double Width { get; }
  double Height { get; }
  XlDisplayUnit DisplayUnit { get; set; }
  double DisplayUnitCustom { get; set; }
  bool HasDisplayUnitLabel { get; set; }
  IMsoDisplayUnitLabel DisplayUnitLabel { get; }
  IMsoBorder Border { get; }
  string Name { get; }
  IMsoChartFormat Format { get; }
}