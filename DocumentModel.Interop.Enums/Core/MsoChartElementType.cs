namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and how to display chart elements.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msochartelementtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoChartElementType")]
public enum ChartElementType
{
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartTitleNone")]
  ChartTitleNone = 0,
  /// <summary>
  /// Display title as centered overlay.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartTitleCenteredOverlay")]
  ChartTitleCenteredOverlay = 1,
  /// <summary>
  /// Display title above chart.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartTitleAboveChart")]
  ChartTitleAboveChart = 2,
  /// <summary>
  /// Do not display legend.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendNone")]
  LegendNone = 100,
  /// <summary>
  /// Display legend at the right.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendRight")]
  LegendRight = 101,
  /// <summary>
  /// Display legend at the top.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendTop")]
  LegendTop = 102,
  /// <summary>
  /// Display legend on the left.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendLeft")]
  LegendLeft = 103,
  /// <summary>
  /// Display legend at the bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendBottom")]
  LegendBottom = 104,
  /// <summary>
  /// Overlay legend at the right.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendRightOverlay")]
  LegendRightOverlay = 105,
  /// <summary>
  /// Overlay legend at the left.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLegendLeftOverlay")]
  LegendLeftOverlay = 106,
  /// <summary>
  /// Do not display data label.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelNone")]
  DataLabelNone = 200,
  /// <summary>
  /// Display data label.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelShow")]
  DataLabelShow = 201,
  /// <summary>
  /// Display data label in center.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelCenter")]
  DataLabelCenter = 202,
  /// <summary>
  /// Display data label inside at the end.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelInsideEnd")]
  DataLabelInsideEnd = 203,
  /// <summary>
  /// Display data label inside at the base.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelInsideBase")]
  DataLabelInsideBase = 204,
  /// <summary>
  /// Display data label outside at the end.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelOutSideEnd")]
  DataLabelOutSideEnd = 205,
  /// <summary>
  /// Display data label to the left.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelLeft")]
  DataLabelLeft = 206,
  /// <summary>
  /// Display data label to the right.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelRight")]
  DataLabelRight = 207,
  /// <summary>
  /// Display data label at the top.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelTop")]
  DataLabelTop = 208,
  /// <summary>
  /// Display data label at bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelBottom")]
  DataLabelBottom = 209,
  /// <summary>
  /// Use best fit for data label.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelBestFit")]
  DataLabelBestFit = 210,
  /// <summary>
  /// Display data label as a callout.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataLabelCallout")]
  DataLabelCallout = 211,
  /// <summary>
  /// Do not display primary category axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisTitleNone")]
  PrimaryCategoryAxisTitleNone = 300,
  /// <summary>
  /// Display primary category axis title adjacent to the axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisTitleAdjacentToAxis")]
  PrimaryCategoryAxisTitleAdjacentToAxis = 301,
  /// <summary>
  /// Display primary category axis title below the axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisTitleBelowAxis")]
  PrimaryCategoryAxisTitleBelowAxis = 302,
  /// <summary>
  /// Rotate primary category axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisTitleRotated")]
  PrimaryCategoryAxisTitleRotated = 303,
  /// <summary>
  /// Display primary category axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisTitleVertical")]
  PrimaryCategoryAxisTitleVertical = 304,
  /// <summary>
  /// Display primary category axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisTitleHorizontal")]
  PrimaryCategoryAxisTitleHorizontal = 305,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisTitleNone")]
  PrimaryValueAxisTitleNone = 306,
  /// <summary>
  /// Place primary value axis title adjacent to the axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisTitleAdjacentToAxis")]
  PrimaryValueAxisTitleAdjacentToAxis = 306,
  /// <summary>
  /// Place primary value axis title below the axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisTitleBelowAxis")]
  PrimaryValueAxisTitleBelowAxis = 308,
  /// <summary>
  /// Rotate primary value axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisTitleRotated")]
  PrimaryValueAxisTitleRotated = 309,
  /// <summary>
  /// Display primary value axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisTitleVertical")]
  PrimaryValueAxisTitleVertical = 310,
  /// <summary>
  /// Display primary value axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisTitleHorizontal")]
  PrimaryValueAxisTitleHorizontal = 311,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisTitleNone")]
  SecondaryCategoryAxisTitleNone = 312,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisTitleAdjacentToAxis")]
  SecondaryCategoryAxisTitleAdjacentToAxis = 313,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisTitleBelowAxis")]
  SecondaryCategoryAxisTitleBelowAxis = 314,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisTitleRotated")]
  SecondaryCategoryAxisTitleRotated = 315,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisTitleVertical")]
  SecondaryCategoryAxisTitleVertical = 316,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisTitleHorizontal")]
  SecondaryCategoryAxisTitleHorizontal = 317,
  /// <summary>
  /// Do not display secondary category axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisTitleNone")]
  SecondaryValueAxisTitleNone = 318,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisTitleAdjacentToAxis")]
  SecondaryValueAxisTitleAdjacentToAxis = 319,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisTitleBelowAxis")]
  SecondaryValueAxisTitleBelowAxis = 320,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisTitleRotated")]
  SecondaryValueAxisTitleRotated = 321,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisTitleVertical")]
  SecondaryValueAxisTitleVertical = 322,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisTitleHorizontal")]
  SecondaryValueAxisTitleHorizontal = 323,
  /// <summary>
  /// Do not display series axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisTitleNone")]
  SeriesAxisTitleNone = 324,
  /// <summary>
  /// Rotate series axis title.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisTitleRotated")]
  SeriesAxisTitleRotated = 325,
  /// <summary>
  /// Display series axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisTitleVertical")]
  SeriesAxisTitleVertical = 326,
  /// <summary>
  /// Display series axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisTitleHorizontal")]
  SeriesAxisTitleHorizontal = 327,
  /// <summary>
  /// Do not display grid lines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueGridLinesNone")]
  PrimaryValueGridLinesNone = 328,
  /// <summary>
  /// Display minor gridlines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueGridLinesMinor")]
  PrimaryValueGridLinesMinor = 329,
  /// <summary>
  /// Display major gridlines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueGridLinesMajor")]
  PrimaryValueGridLinesMajor = 330,
  /// <summary>
  /// Display both major and minor gridlines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueGridLinesMinorMajor")]
  PrimaryValueGridLinesMinorMajor = 331,
  /// <summary>
  /// Do not display grid lines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryGridLinesNone")]
  PrimaryCategoryGridLinesNone = 332,
  /// <summary>
  /// Display minor gridlines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryGridLinesMinor")]
  PrimaryCategoryGridLinesMinor = 333,
  /// <summary>
  /// Display major gridlines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryGridLinesMajor")]
  PrimaryCategoryGridLinesMajor = 334,
  /// <summary>
  /// Display both major and minor gridlines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryGridLinesMinorMajor")]
  PrimaryCategoryGridLinesMinorMajor = 335,
  /// <summary>
  /// Do not display gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueGridLinesNone")]
  SecondaryValueGridLinesNone = 336,
  /// <summary>
  /// Display minor gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueGridLinesMinor")]
  SecondaryValueGridLinesMinor = 337,
  /// <summary>
  /// Display major gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueGridLinesMajor")]
  SecondaryValueGridLinesMajor = 338,
  /// <summary>
  /// Display both major and minor gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueGridLinesMinorMajor")]
  SecondaryValueGridLinesMinorMajor = 339,
  /// <summary>
  /// Do not display grid lines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryGridLinesNone")]
  SecondaryCategoryGridLinesNone = 340,
  /// <summary>
  /// Display minor gridlines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryGridLinesMinor")]
  SecondaryCategoryGridLinesMinor = 341,
  /// <summary>
  /// Display major gridlines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryGridLinesMajor")]
  SecondaryCategoryGridLinesMajor = 342,
  /// <summary>
  /// Display both major and minor gridlines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryGridLinesMinorMajor")]
  SecondaryCategoryGridLinesMinorMajor = 343,
  /// <summary>
  /// Do not display gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisGridLinesNone")]
  SeriesAxisGridLinesNone = 344,
  /// <summary>
  /// Display minor gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisGridLinesMinor")]
  SeriesAxisGridLinesMinor = 345,
  /// <summary>
  /// Display major gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisGridLinesMajor")]
  SeriesAxisGridLinesMajor = 346,
  /// <summary>
  /// Display both major and minor gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisGridLinesMinorMajor")]
  SeriesAxisGridLinesMinorMajor = 347,
  /// <summary>
  /// Do not display primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisNone")]
  PrimaryCategoryAxisNone = 348,
  /// <summary>
  /// Show primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisShow")]
  PrimaryCategoryAxisShow = 349,
  /// <summary>
  /// Display primary category axis without labels.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisWithoutLabels")]
  PrimaryCategoryAxisWithoutLabels = 350,
  /// <summary>
  /// Reverse primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisReverse")]
  PrimaryCategoryAxisReverse = 351,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisNone")]
  PrimaryValueAxisNone = 352,
  /// <summary>
  /// Show primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisShow")]
  PrimaryValueAxisShow = 353,
  /// <summary>
  /// Use thousands for primary value axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisThousands")]
  PrimaryValueAxisThousands = 354,
  /// <summary>
  /// Use millions for primary value axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisMillions")]
  PrimaryValueAxisMillions = 355,
  /// <summary>
  /// Use billions for primary value axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisBillions")]
  PrimaryValueAxisBillions = 356,
  /// <summary>
  /// Use log scale for primary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryValueAxisLogScale")]
  PrimaryValueAxisLogScale = 357,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisNone")]
  SecondaryCategoryAxisNone = 358,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisShow")]
  SecondaryCategoryAxisShow = 359,
  /// <summary>
  /// Display secondary category axis without labels.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisWithoutLabels")]
  SecondaryCategoryAxisWithoutLabels = 360,
  /// <summary>
  /// Reverse secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisReverse")]
  SecondaryCategoryAxisReverse = 361,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisNone")]
  SecondaryValueAxisNone = 362,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisShow")]
  SecondaryValueAxisShow = 363,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisThousands")]
  SecondaryValueAxisThousands = 364,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisMillions")]
  SecondaryValueAxisMillions = 365,
  /// <summary>
  /// Use billions for secondary value axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisBillions")]
  SecondaryValueAxisBillions = 366,
  /// <summary>
  /// Use log scale for secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryValueAxisLogScale")]
  SecondaryValueAxisLogScale = 367,
  /// <summary>
  /// Do not display series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisNone")]
  SeriesAxisNone = 368,
  /// <summary>
  /// Display series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisShow")]
  SeriesAxisShow = 369,
  /// <summary>
  /// Display series axis title without labeling.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisWithoutLabeling")]
  SeriesAxisWithoutLabeling = 370,
  /// <summary>
  /// Reverse series axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSeriesAxisReverse")]
  SeriesAxisReverse = 371,
  /// <summary>
  /// Use thousands for primary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisThousands")]
  PrimaryCategoryAxisThousands = 372,
  /// <summary>
  /// Use millions for primary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisMillions")]
  PrimaryCategoryAxisMillions = 373,
  /// <summary>
  /// Use billions for primary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisBillions")]
  PrimaryCategoryAxisBillions = 374,
  /// <summary>
  /// Use log scale for primary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPrimaryCategoryAxisLogScale")]
  PrimaryCategoryAxisLogScale = 375,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisThousands")]
  SecondaryCategoryAxisThousands = 376,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisMillions")]
  SecondaryCategoryAxisMillions = 377,
  /// <summary>
  /// Use billions for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisBillions")]
  SecondaryCategoryAxisBillions = 378,
  /// <summary>
  /// Use log scale for secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue("msoElementSecondaryCategoryAxisLogScale")]
  SecondaryCategoryAxisLogScale = 379,
  /// <summary>
  /// Do not display data table.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataTableNone")]
  DataTableNone = 500,
  /// <summary>
  /// Display data table.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataTableShow")]
  DataTableShow = 501,
  /// <summary>
  /// Display data table with legend keys.
  /// </summary>
  [OfficeInteropEnumValue("msoElementDataTableWithLegendKeys")]
  DataTableWithLegendKeys = 502,
  /// <summary>
  /// Do not display trendline.
  /// </summary>
  [OfficeInteropEnumValue("msoElementTrendlineNone")]
  TrendlineNone = 600,
  /// <summary>
  /// Add a linear trendline.
  /// </summary>
  [OfficeInteropEnumValue("msoElementTrendlineAddLinear")]
  TrendlineAddLinear = 601,
  /// <summary>
  /// Add an exponential trendline.
  /// </summary>
  [OfficeInteropEnumValue("msoElementTrendlineAddExponential")]
  TrendlineAddExponential = 602,
  /// <summary>
  /// Add a linear forecast.
  /// </summary>
  [OfficeInteropEnumValue("msoElementTrendlineAddLinearForecast")]
  TrendlineAddLinearForecast = 603,
  /// <summary>
  /// Add a two-period moving average.
  /// </summary>
  [OfficeInteropEnumValue("msoElementTrendlineAddTwoPeriodMovingAverage")]
  TrendlineAddTwoPeriodMovingAverage = 604,
  /// <summary>
  /// Do not display error bar.
  /// </summary>
  [OfficeInteropEnumValue("msoElementErrorBarNone")]
  ErrorBarNone = 700,
  /// <summary>
  /// Display standard error bar.
  /// </summary>
  [OfficeInteropEnumValue("msoElementErrorBarStandardError")]
  ErrorBarStandardError = 701,
  /// <summary>
  /// Display percentage error bar.
  /// </summary>
  [OfficeInteropEnumValue("msoElementErrorBarPercentage")]
  ErrorBarPercentage = 702,
  /// <summary>
  /// Display standard deviation error bar.
  /// </summary>
  [OfficeInteropEnumValue("msoElementErrorBarStandardDeviation")]
  ErrorBarStandardDeviation = 703,
  /// <summary>
  /// Do not display line.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLineNone")]
  LineNone = 800,
  /// <summary>
  /// Display drop line.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLineDropLine")]
  LineDropLine = 801,
  /// <summary>
  /// Display high/low line.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLineHiLoLine")]
  LineHiLoLine = 802,
  /// <summary>
  /// Display series line.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLineSeriesLine")]
  LineSeriesLine = 803,
  /// <summary>
  /// Display drop high/low line.
  /// </summary>
  [OfficeInteropEnumValue("msoElementLineDropHiLoLine")]
  LineDropHiLoLine = 804,
  /// <summary>
  /// Do not display up/down bars.
  /// </summary>
  [OfficeInteropEnumValue("msoElementUpDownBarsNone")]
  UpDownBarsNone = 900,
  /// <summary>
  /// Display up/down bars.
  /// </summary>
  [OfficeInteropEnumValue("msoElementUpDownBarsShow")]
  UpDownBarsShow = 901,
  /// <summary>
  /// Do not display plot area.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPlotAreaNone")]
  PlotAreaNone = 1000,
  /// <summary>
  /// Display plot area.
  /// </summary>
  [OfficeInteropEnumValue("msoElementPlotAreaShow")]
  PlotAreaShow = 1001,
  /// <summary>
  /// Do not display chart wall.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartWallNone")]
  ChartWallNone = 1100,
  /// <summary>
  /// Display chart wall.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartWallShow")]
  ChartWallShow = 1101,
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartFloorNone")]
  ChartFloorNone = 1200,
  /// <summary>
  /// Display chart floor.
  /// </summary>
  [OfficeInteropEnumValue("msoElementChartFloorShow")]
  ChartFloorShow = 1201
}
