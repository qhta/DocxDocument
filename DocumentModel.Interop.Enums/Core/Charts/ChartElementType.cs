namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and how to display chart elements.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msochartelementtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoChartElementType")]
public enum ChartElementType
{
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  [InteropEnumValue("msoElementChartTitleNone")]
  ChartTitleNone = 0,
  /// <summary>
  /// Display title as centered overlay.
  /// </summary>
  [InteropEnumValue("msoElementChartTitleCenteredOverlay")]
  ChartTitleCenteredOverlay = 1,
  /// <summary>
  /// Display title above chart.
  /// </summary>
  [InteropEnumValue("msoElementChartTitleAboveChart")]
  ChartTitleAboveChart = 2,
  /// <summary>
  /// Do not display legend.
  /// </summary>
  [InteropEnumValue("msoElementLegendNone")]
  LegendNone = 100,
  /// <summary>
  /// Display legend at the right.
  /// </summary>
  [InteropEnumValue("msoElementLegendRight")]
  LegendRight = 101,
  /// <summary>
  /// Display legend at the top.
  /// </summary>
  [InteropEnumValue("msoElementLegendTop")]
  LegendTop = 102,
  /// <summary>
  /// Display legend on the left.
  /// </summary>
  [InteropEnumValue("msoElementLegendLeft")]
  LegendLeft = 103,
  /// <summary>
  /// Display legend at the bottom.
  /// </summary>
  [InteropEnumValue("msoElementLegendBottom")]
  LegendBottom = 104,
  /// <summary>
  /// Overlay legend at the right.
  /// </summary>
  [InteropEnumValue("msoElementLegendRightOverlay")]
  LegendRightOverlay = 105,
  /// <summary>
  /// Overlay legend at the left.
  /// </summary>
  [InteropEnumValue("msoElementLegendLeftOverlay")]
  LegendLeftOverlay = 106,
  /// <summary>
  /// Do not display data label.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelNone")]
  DataLabelNone = 200,
  /// <summary>
  /// Display data label.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelShow")]
  DataLabelShow = 201,
  /// <summary>
  /// Display data label in center.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelCenter")]
  DataLabelCenter = 202,
  /// <summary>
  /// Display data label inside at the end.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelInsideEnd")]
  DataLabelInsideEnd = 203,
  /// <summary>
  /// Display data label inside at the base.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelInsideBase")]
  DataLabelInsideBase = 204,
  /// <summary>
  /// Display data label outside at the end.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelOutSideEnd")]
  DataLabelOutSideEnd = 205,
  /// <summary>
  /// Display data label to the left.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelLeft")]
  DataLabelLeft = 206,
  /// <summary>
  /// Display data label to the right.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelRight")]
  DataLabelRight = 207,
  /// <summary>
  /// Display data label at the top.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelTop")]
  DataLabelTop = 208,
  /// <summary>
  /// Display data label at bottom.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelBottom")]
  DataLabelBottom = 209,
  /// <summary>
  /// Use best fit for data label.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelBestFit")]
  DataLabelBestFit = 210,
  /// <summary>
  /// Display data label as a callout.
  /// </summary>
  [InteropEnumValue("msoElementDataLabelCallout")]
  DataLabelCallout = 211,
  /// <summary>
  /// Do not display primary category axis title.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisTitleNone")]
  PrimaryCategoryAxisTitleNone = 300,
  /// <summary>
  /// Display primary category axis title adjacent to the axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisTitleAdjacentToAxis")]
  PrimaryCategoryAxisTitleAdjacentToAxis = 301,
  /// <summary>
  /// Display primary category axis title below the axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisTitleBelowAxis")]
  PrimaryCategoryAxisTitleBelowAxis = 302,
  /// <summary>
  /// Rotate primary category axis title.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisTitleRotated")]
  PrimaryCategoryAxisTitleRotated = 303,
  /// <summary>
  /// Display primary category axis title vertically.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisTitleVertical")]
  PrimaryCategoryAxisTitleVertical = 304,
  /// <summary>
  /// Display primary category axis title horizontally.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisTitleHorizontal")]
  PrimaryCategoryAxisTitleHorizontal = 305,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisTitleNone")]
  PrimaryValueAxisTitleNone = 306,
  /// <summary>
  /// Place primary value axis title adjacent to the axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisTitleAdjacentToAxis")]
  PrimaryValueAxisTitleAdjacentToAxis = 306,
  /// <summary>
  /// Place primary value axis title below the axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisTitleBelowAxis")]
  PrimaryValueAxisTitleBelowAxis = 308,
  /// <summary>
  /// Rotate primary value axis title.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisTitleRotated")]
  PrimaryValueAxisTitleRotated = 309,
  /// <summary>
  /// Display primary value axis title vertically.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisTitleVertical")]
  PrimaryValueAxisTitleVertical = 310,
  /// <summary>
  /// Display primary value axis title horizontally.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisTitleHorizontal")]
  PrimaryValueAxisTitleHorizontal = 311,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisTitleNone")]
  SecondaryCategoryAxisTitleNone = 312,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisTitleAdjacentToAxis")]
  SecondaryCategoryAxisTitleAdjacentToAxis = 313,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisTitleBelowAxis")]
  SecondaryCategoryAxisTitleBelowAxis = 314,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisTitleRotated")]
  SecondaryCategoryAxisTitleRotated = 315,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisTitleVertical")]
  SecondaryCategoryAxisTitleVertical = 316,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisTitleHorizontal")]
  SecondaryCategoryAxisTitleHorizontal = 317,
  /// <summary>
  /// Do not display secondary category axis title.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisTitleNone")]
  SecondaryValueAxisTitleNone = 318,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisTitleAdjacentToAxis")]
  SecondaryValueAxisTitleAdjacentToAxis = 319,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisTitleBelowAxis")]
  SecondaryValueAxisTitleBelowAxis = 320,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisTitleRotated")]
  SecondaryValueAxisTitleRotated = 321,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisTitleVertical")]
  SecondaryValueAxisTitleVertical = 322,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisTitleHorizontal")]
  SecondaryValueAxisTitleHorizontal = 323,
  /// <summary>
  /// Do not display series axis title.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisTitleNone")]
  SeriesAxisTitleNone = 324,
  /// <summary>
  /// Rotate series axis title.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisTitleRotated")]
  SeriesAxisTitleRotated = 325,
  /// <summary>
  /// Display series axis title vertically.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisTitleVertical")]
  SeriesAxisTitleVertical = 326,
  /// <summary>
  /// Display series axis title horizontally.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisTitleHorizontal")]
  SeriesAxisTitleHorizontal = 327,
  /// <summary>
  /// Do not display grid lines along primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueGridLinesNone")]
  PrimaryValueGridLinesNone = 328,
  /// <summary>
  /// Display minor gridlines along primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueGridLinesMinor")]
  PrimaryValueGridLinesMinor = 329,
  /// <summary>
  /// Display major gridlines along primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueGridLinesMajor")]
  PrimaryValueGridLinesMajor = 330,
  /// <summary>
  /// Display both major and minor gridlines along primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueGridLinesMinorMajor")]
  PrimaryValueGridLinesMinorMajor = 331,
  /// <summary>
  /// Do not display grid lines along primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryGridLinesNone")]
  PrimaryCategoryGridLinesNone = 332,
  /// <summary>
  /// Display minor gridlines along primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryGridLinesMinor")]
  PrimaryCategoryGridLinesMinor = 333,
  /// <summary>
  /// Display major gridlines along primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryGridLinesMajor")]
  PrimaryCategoryGridLinesMajor = 334,
  /// <summary>
  /// Display both major and minor gridlines along primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryGridLinesMinorMajor")]
  PrimaryCategoryGridLinesMinorMajor = 335,
  /// <summary>
  /// Do not display gridlines along secondary value axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueGridLinesNone")]
  SecondaryValueGridLinesNone = 336,
  /// <summary>
  /// Display minor gridlines along secondary value axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueGridLinesMinor")]
  SecondaryValueGridLinesMinor = 337,
  /// <summary>
  /// Display major gridlines along secondary value axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueGridLinesMajor")]
  SecondaryValueGridLinesMajor = 338,
  /// <summary>
  /// Display both major and minor gridlines along secondary value axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueGridLinesMinorMajor")]
  SecondaryValueGridLinesMinorMajor = 339,
  /// <summary>
  /// Do not display grid lines along secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryGridLinesNone")]
  SecondaryCategoryGridLinesNone = 340,
  /// <summary>
  /// Display minor gridlines along secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryGridLinesMinor")]
  SecondaryCategoryGridLinesMinor = 341,
  /// <summary>
  /// Display major gridlines along secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryGridLinesMajor")]
  SecondaryCategoryGridLinesMajor = 342,
  /// <summary>
  /// Display both major and minor gridlines along secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryGridLinesMinorMajor")]
  SecondaryCategoryGridLinesMinorMajor = 343,
  /// <summary>
  /// Do not display gridlines along series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisGridLinesNone")]
  SeriesAxisGridLinesNone = 344,
  /// <summary>
  /// Display minor gridlines along series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisGridLinesMinor")]
  SeriesAxisGridLinesMinor = 345,
  /// <summary>
  /// Display major gridlines along series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisGridLinesMajor")]
  SeriesAxisGridLinesMajor = 346,
  /// <summary>
  /// Display both major and minor gridlines along series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisGridLinesMinorMajor")]
  SeriesAxisGridLinesMinorMajor = 347,
  /// <summary>
  /// Do not display primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisNone")]
  PrimaryCategoryAxisNone = 348,
  /// <summary>
  /// Show primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisShow")]
  PrimaryCategoryAxisShow = 349,
  /// <summary>
  /// Display primary category axis without labels.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisWithoutLabels")]
  PrimaryCategoryAxisWithoutLabels = 350,
  /// <summary>
  /// Reverse primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisReverse")]
  PrimaryCategoryAxisReverse = 351,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisNone")]
  PrimaryValueAxisNone = 352,
  /// <summary>
  /// Show primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisShow")]
  PrimaryValueAxisShow = 353,
  /// <summary>
  /// Use thousands for primary value axis units.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisThousands")]
  PrimaryValueAxisThousands = 354,
  /// <summary>
  /// Use millions for primary value axis units.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisMillions")]
  PrimaryValueAxisMillions = 355,
  /// <summary>
  /// Use billions for primary value axis units.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisBillions")]
  PrimaryValueAxisBillions = 356,
  /// <summary>
  /// Use log scale for primary value axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryValueAxisLogScale")]
  PrimaryValueAxisLogScale = 357,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisNone")]
  SecondaryCategoryAxisNone = 358,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisShow")]
  SecondaryCategoryAxisShow = 359,
  /// <summary>
  /// Display secondary category axis without labels.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisWithoutLabels")]
  SecondaryCategoryAxisWithoutLabels = 360,
  /// <summary>
  /// Reverse secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisReverse")]
  SecondaryCategoryAxisReverse = 361,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisNone")]
  SecondaryValueAxisNone = 362,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisShow")]
  SecondaryValueAxisShow = 363,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisThousands")]
  SecondaryValueAxisThousands = 364,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisMillions")]
  SecondaryValueAxisMillions = 365,
  /// <summary>
  /// Use billions for secondary value axis units.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisBillions")]
  SecondaryValueAxisBillions = 366,
  /// <summary>
  /// Use log scale for secondary value axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryValueAxisLogScale")]
  SecondaryValueAxisLogScale = 367,
  /// <summary>
  /// Do not display series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisNone")]
  SeriesAxisNone = 368,
  /// <summary>
  /// Display series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisShow")]
  SeriesAxisShow = 369,
  /// <summary>
  /// Display series axis title without labeling.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisWithoutLabeling")]
  SeriesAxisWithoutLabeling = 370,
  /// <summary>
  /// Reverse series axis.
  /// </summary>
  [InteropEnumValue("msoElementSeriesAxisReverse")]
  SeriesAxisReverse = 371,
  /// <summary>
  /// Use thousands for primary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisThousands")]
  PrimaryCategoryAxisThousands = 372,
  /// <summary>
  /// Use millions for primary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisMillions")]
  PrimaryCategoryAxisMillions = 373,
  /// <summary>
  /// Use billions for primary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisBillions")]
  PrimaryCategoryAxisBillions = 374,
  /// <summary>
  /// Use log scale for primary category axis.
  /// </summary>
  [InteropEnumValue("msoElementPrimaryCategoryAxisLogScale")]
  PrimaryCategoryAxisLogScale = 375,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisThousands")]
  SecondaryCategoryAxisThousands = 376,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisMillions")]
  SecondaryCategoryAxisMillions = 377,
  /// <summary>
  /// Use billions for secondary category axis units.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisBillions")]
  SecondaryCategoryAxisBillions = 378,
  /// <summary>
  /// Use log scale for secondary category axis.
  /// </summary>
  [InteropEnumValue("msoElementSecondaryCategoryAxisLogScale")]
  SecondaryCategoryAxisLogScale = 379,
  /// <summary>
  /// Do not display data table.
  /// </summary>
  [InteropEnumValue("msoElementDataTableNone")]
  DataTableNone = 500,
  /// <summary>
  /// Display data table.
  /// </summary>
  [InteropEnumValue("msoElementDataTableShow")]
  DataTableShow = 501,
  /// <summary>
  /// Display data table with legend keys.
  /// </summary>
  [InteropEnumValue("msoElementDataTableWithLegendKeys")]
  DataTableWithLegendKeys = 502,
  /// <summary>
  /// Do not display trendline.
  /// </summary>
  [InteropEnumValue("msoElementTrendlineNone")]
  TrendlineNone = 600,
  /// <summary>
  /// Add a linear trendline.
  /// </summary>
  [InteropEnumValue("msoElementTrendlineAddLinear")]
  TrendlineAddLinear = 601,
  /// <summary>
  /// Add an exponential trendline.
  /// </summary>
  [InteropEnumValue("msoElementTrendlineAddExponential")]
  TrendlineAddExponential = 602,
  /// <summary>
  /// Add a linear forecast.
  /// </summary>
  [InteropEnumValue("msoElementTrendlineAddLinearForecast")]
  TrendlineAddLinearForecast = 603,
  /// <summary>
  /// Add a two-period moving average.
  /// </summary>
  [InteropEnumValue("msoElementTrendlineAddTwoPeriodMovingAverage")]
  TrendlineAddTwoPeriodMovingAverage = 604,
  /// <summary>
  /// Do not display error bar.
  /// </summary>
  [InteropEnumValue("msoElementErrorBarNone")]
  ErrorBarNone = 700,
  /// <summary>
  /// Display standard error bar.
  /// </summary>
  [InteropEnumValue("msoElementErrorBarStandardError")]
  ErrorBarStandardError = 701,
  /// <summary>
  /// Display percentage error bar.
  /// </summary>
  [InteropEnumValue("msoElementErrorBarPercentage")]
  ErrorBarPercentage = 702,
  /// <summary>
  /// Display standard deviation error bar.
  /// </summary>
  [InteropEnumValue("msoElementErrorBarStandardDeviation")]
  ErrorBarStandardDeviation = 703,
  /// <summary>
  /// Do not display line.
  /// </summary>
  [InteropEnumValue("msoElementLineNone")]
  LineNone = 800,
  /// <summary>
  /// Display drop line.
  /// </summary>
  [InteropEnumValue("msoElementLineDropLine")]
  LineDropLine = 801,
  /// <summary>
  /// Display high/low line.
  /// </summary>
  [InteropEnumValue("msoElementLineHiLoLine")]
  LineHiLoLine = 802,
  /// <summary>
  /// Display series line.
  /// </summary>
  [InteropEnumValue("msoElementLineSeriesLine")]
  LineSeriesLine = 803,
  /// <summary>
  /// Display drop high/low line.
  /// </summary>
  [InteropEnumValue("msoElementLineDropHiLoLine")]
  LineDropHiLoLine = 804,
  /// <summary>
  /// Do not display up/down bars.
  /// </summary>
  [InteropEnumValue("msoElementUpDownBarsNone")]
  UpDownBarsNone = 900,
  /// <summary>
  /// Display up/down bars.
  /// </summary>
  [InteropEnumValue("msoElementUpDownBarsShow")]
  UpDownBarsShow = 901,
  /// <summary>
  /// Do not display plot area.
  /// </summary>
  [InteropEnumValue("msoElementPlotAreaNone")]
  PlotAreaNone = 1000,
  /// <summary>
  /// Display plot area.
  /// </summary>
  [InteropEnumValue("msoElementPlotAreaShow")]
  PlotAreaShow = 1001,
  /// <summary>
  /// Do not display chart wall.
  /// </summary>
  [InteropEnumValue("msoElementChartWallNone")]
  ChartWallNone = 1100,
  /// <summary>
  /// Display chart wall.
  /// </summary>
  [InteropEnumValue("msoElementChartWallShow")]
  ChartWallShow = 1101,
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  [InteropEnumValue("msoElementChartFloorNone")]
  ChartFloorNone = 1200,
  /// <summary>
  /// Display chart floor.
  /// </summary>
  [InteropEnumValue("msoElementChartFloorShow")]
  ChartFloorShow = 1201
}
