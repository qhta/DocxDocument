namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and how to display chart elements.
/// </summary>
public enum MsoChartElementType
{
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  ChartTitleNone = 0,
  /// <summary>
  /// Display title as centered overlay.
  /// </summary>
  ChartTitleCenteredOverlay = 1,
  /// <summary>
  /// Display title above chart.
  /// </summary>
  ChartTitleAboveChart = 2,
  /// <summary>
  /// Do not display legend.
  /// </summary>
  LegendNone = 100,
  /// <summary>
  /// Display legend at the right.
  /// </summary>
  LegendRight = 101,
  /// <summary>
  /// Display legend at the top.
  /// </summary>
  LegendTop = 102,
  /// <summary>
  /// Display legend on the left.
  /// </summary>
  LegendLeft = 103,
  /// <summary>
  /// Display legend at the bottom.
  /// </summary>
  LegendBottom = 104,
  /// <summary>
  /// Overlay legend at the right.
  /// </summary>
  LegendRightOverlay = 105,
  /// <summary>
  /// Overlay legend at the left.
  /// </summary>
  LegendLeftOverlay = 106,
  /// <summary>
  /// Do not display data label.
  /// </summary>
  DataLabelNone = 200,
  /// <summary>
  /// Display data label.
  /// </summary>
  DataLabelShow = 201,
  /// <summary>
  /// Display data label in center. public enum class MsoChartElementType ﾉ Expand table
  /// </summary>
  DataLabelCenter = 202,
  /// <summary>
  /// Display data label inside at the end.
  /// </summary>
  DataLabelInsideEnd = 203,
  /// <summary>
  /// Display data label inside at the base.
  /// </summary>
  DataLabelInsideBase = 204,
  /// <summary>
  /// Display data label outside at the end.
  /// </summary>
  DataLabelOutSideEnd = 205,
  /// <summary>
  /// Display data label to the left.
  /// </summary>
  DataLabelLeft = 206,
  /// <summary>
  /// Display data label to the right.
  /// </summary>
  DataLabelRight = 207,
  /// <summary>
  /// Display data label at the top.
  /// </summary>
  DataLabelTop = 208,
  /// <summary>
  /// Display data label at bottom.
  /// </summary>
  DataLabelBottom = 209,
  /// <summary>
  /// Use best fit for data label.
  /// </summary>
  DataLabelBestFit = 210,
  /// <summary>
  /// Display data label as a callout.
  /// </summary>
  DataLabelCallout = 211,
  /// <summary>
  /// Do not display primary category axis title.
  /// </summary>
  PrimaryCategoryAxisTitleNone = 300,
  /// <summary>
  /// Display primary category axis title adjacent to the axis. msoElementPrimaryCategoryAxisTitleBelowAxis302
  /// Display primary category axis title below the axis.
  /// </summary>
  PrimaryCategoryAxisTitleAdjacentToAxis = 301,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryAxisTitleBelowAxis = 302,
  /// <summary>
  /// Rotate primary category axis title.
  /// </summary>
  PrimaryCategoryAxisTitleRotated = 303,
  /// <summary>
  /// Display primary category axis title vertically. msoElementPrimaryCategoryAxisTitleHorizontal305 Display
  /// primary category axis title horizontally.
  /// </summary>
  PrimaryCategoryAxisTitleVertical = 304,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryAxisTitleHorizontal = 305,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  PrimaryValueAxisTitleNone = 306,
  /// <summary>
  /// Place primary value axis title adjacent to the axis.
  /// </summary>
  PrimaryValueAxisTitleAdjacentToAxis = 306,
  /// <summary>
  /// Place primary value axis title below the axis.
  /// </summary>
  PrimaryValueAxisTitleBelowAxis = 308,
  /// <summary>
  /// Rotate primary value axis title.
  /// </summary>
  PrimaryValueAxisTitleRotated = 309,
  /// <summary>
  /// Display primary value axis title vertically.
  /// </summary>
  PrimaryValueAxisTitleVertical = 310,
  /// <summary>
  /// Display primary value axis title horizontally. msoElementSecondaryCategoryAxisTitleNone312 Do not display
  /// secondary category axis.
  /// </summary>
  PrimaryValueAxisTitleHorizontal = 311,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisTitleNone = 312,
  /// <summary>
  /// Display secondary category axis title adjacent to axis. msoElementSecondaryCategoryAxisTitleBelowAxis314
  /// Display secondary category axis title below axis.
  /// </summary>
  SecondaryCategoryAxisTitleAdjacentToAxis = 313,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisTitleBelowAxis = 314,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  SecondaryCategoryAxisTitleRotated = 315,
  /// <summary>
  /// Display secondary category axis title vertically. msoElementSecondaryCategoryAxisTitleHorizontal317 Display
  /// secondary category axis title horizontally.
  /// </summary>
  SecondaryCategoryAxisTitleVertical = 316,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisTitleHorizontal = 317,
  /// <summary>
  /// Do not display secondary category axis title.
  /// </summary>
  SecondaryValueAxisTitleNone = 318,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  SecondaryValueAxisTitleAdjacentToAxis = 319,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  SecondaryValueAxisTitleBelowAxis = 320,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  SecondaryValueAxisTitleRotated = 321,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  SecondaryValueAxisTitleVertical = 322,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  SecondaryValueAxisTitleHorizontal = 323,
  /// <summary>
  /// Do not display series axis title.
  /// </summary>
  SeriesAxisTitleNone = 324,
  /// <summary>
  /// Rotate series axis title.
  /// </summary>
  SeriesAxisTitleRotated = 325,
  /// <summary>
  /// Display series axis title vertically.
  /// </summary>
  SeriesAxisTitleVertical = 326,
  /// <summary>
  /// Display series axis title horizontally.
  /// </summary>
  SeriesAxisTitleHorizontal = 327,
  /// <summary>
  /// Do not display grid lines along primary value axis.
  /// </summary>
  PrimaryValueGridLinesNone = 328,
  /// <summary>
  /// Display minor gridlines along primary value axis.
  /// </summary>
  PrimaryValueGridLinesMinor = 329,
  /// <summary>
  /// Display major gridlines along primary value axis.
  /// </summary>
  PrimaryValueGridLinesMajor = 330,
  /// <summary>
  /// Display both major and minor gridlines along primary value axis. msoElementPrimaryCategoryGridLinesNone332 Do
  /// not display grid lines along primary category axis. msoElementPrimaryCategoryGridLinesMinor333 Display minor
  /// gridlines along primary category axis. msoElementPrimaryCategoryGridLinesMajor334 Display major gridlines
  /// along primary category axis. msoElementPrimaryCategoryGridLinesMinorMajor335 Display both major and minor
  /// gridlines along primary category axis.
  /// </summary>
  PrimaryValueGridLinesMinorMajor = 331,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryGridLinesNone = 332,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryGridLinesMinor = 333,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryGridLinesMajor = 334,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryGridLinesMinorMajor = 335,
  /// <summary>
  /// Do not display gridlines along secondary value axis.
  /// </summary>
  SecondaryValueGridLinesNone = 336,
  /// <summary>
  /// Display minor gridlines along secondary value axis.
  /// </summary>
  SecondaryValueGridLinesMinor = 337,
  /// <summary>
  /// Display major gridlines along secondary value axis. msoElementSecondaryValueGridLinesMinorMajor339 Display
  /// both major and minor gridlines along secondary value axis. msoElementSecondaryCategoryGridLinesNone340 Do not
  /// display grid lines along secondary category axis. msoElementSecondaryCategoryGridLinesMinor341 Display minor
  /// gridlines along secondary category axis. msoElementSecondaryCategoryGridLinesMajor342 Display major gridlines
  /// along secondary category axis. msoElementSecondaryCategoryGridLinesMinorMajor343 Display both major and minor
  /// gridlines along secondary category axis.
  /// </summary>
  SecondaryValueGridLinesMajor = 338,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryValueGridLinesMinorMajor = 339,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryGridLinesNone = 340,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryGridLinesMinor = 341,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryGridLinesMajor = 342,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryGridLinesMinorMajor = 343,
  /// <summary>
  /// Do not display gridlines along series axis.
  /// </summary>
  SeriesAxisGridLinesNone = 344,
  /// <summary>
  /// Display minor gridlines along series axis.
  /// </summary>
  SeriesAxisGridLinesMinor = 345,
  /// <summary>
  /// Display major gridlines along series axis. msoElementSeriesAxisGridLinesMinorMajor347 Display both major and
  /// minor gridlines along series axis.
  /// </summary>
  SeriesAxisGridLinesMajor = 346,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SeriesAxisGridLinesMinorMajor = 347,
  /// <summary>
  /// Do not display primary category axis.
  /// </summary>
  PrimaryCategoryAxisNone = 348,
  /// <summary>
  /// Show primary category axis. msoElementPrimaryCategoryAxisWithoutLabels350 Display primary category axis
  /// without labels.
  /// </summary>
  PrimaryCategoryAxisShow = 349,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryAxisWithoutLabels = 350,
  /// <summary>
  /// Reverse primary category axis.
  /// </summary>
  PrimaryCategoryAxisReverse = 351,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  PrimaryValueAxisNone = 352,
  /// <summary>
  /// Show primary value axis.
  /// </summary>
  PrimaryValueAxisShow = 353,
  /// <summary>
  /// Use thousands for primary value axis units.
  /// </summary>
  PrimaryValueAxisThousands = 354,
  /// <summary>
  /// Use millions for primary value axis units.
  /// </summary>
  PrimaryValueAxisMillions = 355,
  /// <summary>
  /// Use billions for primary value axis units.
  /// </summary>
  PrimaryValueAxisBillions = 356,
  /// <summary>
  /// Use log scale for primary value axis.
  /// </summary>
  PrimaryValueAxisLogScale = 357,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  SecondaryCategoryAxisNone = 358,
  /// <summary>
  /// Display secondary category axis. msoElementSecondaryCategoryAxisWithoutLabels360 Display secondary category
  /// axis without labels.
  /// </summary>
  SecondaryCategoryAxisShow = 359,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisWithoutLabels = 360,
  /// <summary>
  /// Reverse secondary category axis.
  /// </summary>
  SecondaryCategoryAxisReverse = 361,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  SecondaryValueAxisNone = 362,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  SecondaryValueAxisShow = 363,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  SecondaryValueAxisThousands = 364,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  SecondaryValueAxisMillions = 365,
  /// <summary>
  /// Use billions for secondary value axis units.
  /// </summary>
  SecondaryValueAxisBillions = 366,
  /// <summary>
  /// Use log scale for secondary value axis.
  /// </summary>
  SecondaryValueAxisLogScale = 367,
  /// <summary>
  /// Do not display series axis.
  /// </summary>
  SeriesAxisNone = 368,
  /// <summary>
  /// Display series axis.
  /// </summary>
  SeriesAxisShow = 369,
  /// <summary>
  /// Display series axis title without labeling.
  /// </summary>
  SeriesAxisWithoutLabeling = 370,
  /// <summary>
  /// Reverse series axis. msoElementPrimaryCategoryAxisThousands372 Use thousands for primary category axis units.
  /// </summary>
  SeriesAxisReverse = 371,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryAxisThousands = 372,
  /// <summary>
  /// Use millions for primary category axis units.
  /// </summary>
  PrimaryCategoryAxisMillions = 373,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryAxisBillions = 374,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PrimaryCategoryAxisLogScale = 375,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisThousands = 376,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisMillions = 377,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisBillions = 378,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  SecondaryCategoryAxisLogScale = 379,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  DataTableNone = 500,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  DataTableShow = 501,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  DataTableWithLegendKeys = 502,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  TrendlineNone = 600,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  TrendlineAddLinear = 601,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  TrendlineAddExponential = 602,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  TrendlineAddLinearForecast = 603,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  TrendlineAddTwoPeriodMovingAverage = 604,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ErrorBarNone = 700,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ErrorBarStandardError = 701,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ErrorBarPercentage = 702,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ErrorBarStandardDeviation = 703,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  LineNone = 800,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  LineDropLine = 801,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  LineHiLoLine = 802,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  LineSeriesLine = 803,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  LineDropHiLoLine = 804,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  UpDownBarsNone = 900,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  UpDownBarsShow = 901,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PlotAreaNone = 1000,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  PlotAreaShow = 1001,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ChartWallNone = 1100,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ChartWallShow = 1101,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ChartFloorNone = 1200,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  ChartFloorShow = 1201
}
