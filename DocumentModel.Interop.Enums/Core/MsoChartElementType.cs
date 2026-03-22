namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and how to display chart elements.
/// </summary>
public enum MsoChartElementType
{
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  msoElementChartTitleNone = 0,
  /// <summary>
  /// Display title as centered overlay.
  /// </summary>
  msoElementChartTitleCenteredOverlay = 1,
  /// <summary>
  /// Display title above chart.
  /// </summary>
  msoElementChartTitleAboveChart = 2,
  /// <summary>
  /// Do not display legend.
  /// </summary>
  msoElementLegendNone = 100,
  /// <summary>
  /// Display legend at the right.
  /// </summary>
  msoElementLegendRight = 101,
  /// <summary>
  /// Display legend at the top.
  /// </summary>
  msoElementLegendTop = 102,
  /// <summary>
  /// Display legend on the left.
  /// </summary>
  msoElementLegendLeft = 103,
  /// <summary>
  /// Display legend at the bottom.
  /// </summary>
  msoElementLegendBottom = 104,
  /// <summary>
  /// Overlay legend at the right.
  /// </summary>
  msoElementLegendRightOverlay = 105,
  /// <summary>
  /// Overlay legend at the left.
  /// </summary>
  msoElementLegendLeftOverlay = 106,
  /// <summary>
  /// Do not display data label.
  /// </summary>
  msoElementDataLabelNone = 200,
  /// <summary>
  /// Display data label.
  /// </summary>
  msoElementDataLabelShow = 201,
  /// <summary>
  /// Display data label in center. public enum class MsoChartElementType ﾉ Expand table
  /// </summary>
  msoElementDataLabelCenter = 202,
  /// <summary>
  /// Display data label inside at the end.
  /// </summary>
  msoElementDataLabelInsideEnd = 203,
  /// <summary>
  /// Display data label inside at the base.
  /// </summary>
  msoElementDataLabelInsideBase = 204,
  /// <summary>
  /// Display data label outside at the end.
  /// </summary>
  msoElementDataLabelOutSideEnd = 205,
  /// <summary>
  /// Display data label to the left.
  /// </summary>
  msoElementDataLabelLeft = 206,
  /// <summary>
  /// Display data label to the right.
  /// </summary>
  msoElementDataLabelRight = 207,
  /// <summary>
  /// Display data label at the top.
  /// </summary>
  msoElementDataLabelTop = 208,
  /// <summary>
  /// Display data label at bottom.
  /// </summary>
  msoElementDataLabelBottom = 209,
  /// <summary>
  /// Use best fit for data label.
  /// </summary>
  msoElementDataLabelBestFit = 210,
  /// <summary>
  /// Display data label as a callout.
  /// </summary>
  msoElementDataLabelCallout = 211,
  /// <summary>
  /// Do not display primary category axis title.
  /// </summary>
  msoElementPrimaryCategoryAxisTitleNone = 300,
  /// <summary>
  /// Display primary category axis title adjacent to the axis. msoElementPrimaryCategoryAxisTitleBelowAxis302
  /// Display primary category axis title below the axis.
  /// </summary>
  msoElementPrimaryCategoryAxisTitleAdjacentToAxis = 301,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryAxisTitleBelowAxis = 302,
  /// <summary>
  /// Rotate primary category axis title.
  /// </summary>
  msoElementPrimaryCategoryAxisTitleRotated = 303,
  /// <summary>
  /// Display primary category axis title vertically. msoElementPrimaryCategoryAxisTitleHorizontal305 Display
  /// primary category axis title horizontally.
  /// </summary>
  msoElementPrimaryCategoryAxisTitleVertical = 304,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryAxisTitleHorizontal = 305,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  msoElementPrimaryValueAxisTitleNone = 306,
  /// <summary>
  /// Place primary value axis title adjacent to the axis.
  /// </summary>
  msoElementPrimaryValueAxisTitleAdjacentToAxis = 306,
  /// <summary>
  /// Place primary value axis title below the axis.
  /// </summary>
  msoElementPrimaryValueAxisTitleBelowAxis = 308,
  /// <summary>
  /// Rotate primary value axis title.
  /// </summary>
  msoElementPrimaryValueAxisTitleRotated = 309,
  /// <summary>
  /// Display primary value axis title vertically.
  /// </summary>
  msoElementPrimaryValueAxisTitleVertical = 310,
  /// <summary>
  /// Display primary value axis title horizontally. msoElementSecondaryCategoryAxisTitleNone312 Do not display
  /// secondary category axis.
  /// </summary>
  msoElementPrimaryValueAxisTitleHorizontal = 311,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisTitleNone = 312,
  /// <summary>
  /// Display secondary category axis title adjacent to axis. msoElementSecondaryCategoryAxisTitleBelowAxis314
  /// Display secondary category axis title below axis.
  /// </summary>
  msoElementSecondaryCategoryAxisTitleAdjacentToAxis = 313,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisTitleBelowAxis = 314,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  msoElementSecondaryCategoryAxisTitleRotated = 315,
  /// <summary>
  /// Display secondary category axis title vertically. msoElementSecondaryCategoryAxisTitleHorizontal317 Display
  /// secondary category axis title horizontally.
  /// </summary>
  msoElementSecondaryCategoryAxisTitleVertical = 316,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisTitleHorizontal = 317,
  /// <summary>
  /// Do not display secondary category axis title.
  /// </summary>
  msoElementSecondaryValueAxisTitleNone = 318,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  msoElementSecondaryValueAxisTitleAdjacentToAxis = 319,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  msoElementSecondaryValueAxisTitleBelowAxis = 320,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  msoElementSecondaryValueAxisTitleRotated = 321,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  msoElementSecondaryValueAxisTitleVertical = 322,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  msoElementSecondaryValueAxisTitleHorizontal = 323,
  /// <summary>
  /// Do not display series axis title.
  /// </summary>
  msoElementSeriesAxisTitleNone = 324,
  /// <summary>
  /// Rotate series axis title.
  /// </summary>
  msoElementSeriesAxisTitleRotated = 325,
  /// <summary>
  /// Display series axis title vertically.
  /// </summary>
  msoElementSeriesAxisTitleVertical = 326,
  /// <summary>
  /// Display series axis title horizontally.
  /// </summary>
  msoElementSeriesAxisTitleHorizontal = 327,
  /// <summary>
  /// Do not display grid lines along primary value axis.
  /// </summary>
  msoElementPrimaryValueGridLinesNone = 328,
  /// <summary>
  /// Display minor gridlines along primary value axis.
  /// </summary>
  msoElementPrimaryValueGridLinesMinor = 329,
  /// <summary>
  /// Display major gridlines along primary value axis.
  /// </summary>
  msoElementPrimaryValueGridLinesMajor = 330,
  /// <summary>
  /// Display both major and minor gridlines along primary value axis. msoElementPrimaryCategoryGridLinesNone332 Do
  /// not display grid lines along primary category axis. msoElementPrimaryCategoryGridLinesMinor333 Display minor
  /// gridlines along primary category axis. msoElementPrimaryCategoryGridLinesMajor334 Display major gridlines
  /// along primary category axis. msoElementPrimaryCategoryGridLinesMinorMajor335 Display both major and minor
  /// gridlines along primary category axis.
  /// </summary>
  msoElementPrimaryValueGridLinesMinorMajor = 331,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryGridLinesNone = 332,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryGridLinesMinor = 333,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryGridLinesMajor = 334,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryGridLinesMinorMajor = 335,
  /// <summary>
  /// Do not display gridlines along secondary value axis.
  /// </summary>
  msoElementSecondaryValueGridLinesNone = 336,
  /// <summary>
  /// Display minor gridlines along secondary value axis.
  /// </summary>
  msoElementSecondaryValueGridLinesMinor = 337,
  /// <summary>
  /// Display major gridlines along secondary value axis. msoElementSecondaryValueGridLinesMinorMajor339 Display
  /// both major and minor gridlines along secondary value axis. msoElementSecondaryCategoryGridLinesNone340 Do not
  /// display grid lines along secondary category axis. msoElementSecondaryCategoryGridLinesMinor341 Display minor
  /// gridlines along secondary category axis. msoElementSecondaryCategoryGridLinesMajor342 Display major gridlines
  /// along secondary category axis. msoElementSecondaryCategoryGridLinesMinorMajor343 Display both major and minor
  /// gridlines along secondary category axis.
  /// </summary>
  msoElementSecondaryValueGridLinesMajor = 338,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryValueGridLinesMinorMajor = 339,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryGridLinesNone = 340,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryGridLinesMinor = 341,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryGridLinesMajor = 342,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryGridLinesMinorMajor = 343,
  /// <summary>
  /// Do not display gridlines along series axis.
  /// </summary>
  msoElementSeriesAxisGridLinesNone = 344,
  /// <summary>
  /// Display minor gridlines along series axis.
  /// </summary>
  msoElementSeriesAxisGridLinesMinor = 345,
  /// <summary>
  /// Display major gridlines along series axis. msoElementSeriesAxisGridLinesMinorMajor347 Display both major and
  /// minor gridlines along series axis.
  /// </summary>
  msoElementSeriesAxisGridLinesMajor = 346,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSeriesAxisGridLinesMinorMajor = 347,
  /// <summary>
  /// Do not display primary category axis.
  /// </summary>
  msoElementPrimaryCategoryAxisNone = 348,
  /// <summary>
  /// Show primary category axis. msoElementPrimaryCategoryAxisWithoutLabels350 Display primary category axis
  /// without labels.
  /// </summary>
  msoElementPrimaryCategoryAxisShow = 349,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryAxisWithoutLabels = 350,
  /// <summary>
  /// Reverse primary category axis.
  /// </summary>
  msoElementPrimaryCategoryAxisReverse = 351,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  msoElementPrimaryValueAxisNone = 352,
  /// <summary>
  /// Show primary value axis.
  /// </summary>
  msoElementPrimaryValueAxisShow = 353,
  /// <summary>
  /// Use thousands for primary value axis units.
  /// </summary>
  msoElementPrimaryValueAxisThousands = 354,
  /// <summary>
  /// Use millions for primary value axis units.
  /// </summary>
  msoElementPrimaryValueAxisMillions = 355,
  /// <summary>
  /// Use billions for primary value axis units.
  /// </summary>
  msoElementPrimaryValueAxisBillions = 356,
  /// <summary>
  /// Use log scale for primary value axis.
  /// </summary>
  msoElementPrimaryValueAxisLogScale = 357,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  msoElementSecondaryCategoryAxisNone = 358,
  /// <summary>
  /// Display secondary category axis. msoElementSecondaryCategoryAxisWithoutLabels360 Display secondary category
  /// axis without labels.
  /// </summary>
  msoElementSecondaryCategoryAxisShow = 359,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisWithoutLabels = 360,
  /// <summary>
  /// Reverse secondary category axis.
  /// </summary>
  msoElementSecondaryCategoryAxisReverse = 361,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  msoElementSecondaryValueAxisNone = 362,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  msoElementSecondaryValueAxisShow = 363,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  msoElementSecondaryValueAxisThousands = 364,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  msoElementSecondaryValueAxisMillions = 365,
  /// <summary>
  /// Use billions for secondary value axis units.
  /// </summary>
  msoElementSecondaryValueAxisBillions = 366,
  /// <summary>
  /// Use log scale for secondary value axis.
  /// </summary>
  msoElementSecondaryValueAxisLogScale = 367,
  /// <summary>
  /// Do not display series axis.
  /// </summary>
  msoElementSeriesAxisNone = 368,
  /// <summary>
  /// Display series axis.
  /// </summary>
  msoElementSeriesAxisShow = 369,
  /// <summary>
  /// Display series axis title without labeling.
  /// </summary>
  msoElementSeriesAxisWithoutLabeling = 370,
  /// <summary>
  /// Reverse series axis. msoElementPrimaryCategoryAxisThousands372 Use thousands for primary category axis units.
  /// </summary>
  msoElementSeriesAxisReverse = 371,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryAxisThousands = 372,
  /// <summary>
  /// Use millions for primary category axis units.
  /// </summary>
  msoElementPrimaryCategoryAxisMillions = 373,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryAxisBillions = 374,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPrimaryCategoryAxisLogScale = 375,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisThousands = 376,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisMillions = 377,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisBillions = 378,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementSecondaryCategoryAxisLogScale = 379,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementDataTableNone = 500,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementDataTableShow = 501,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementDataTableWithLegendKeys = 502,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementTrendlineNone = 600,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementTrendlineAddLinear = 601,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementTrendlineAddExponential = 602,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementTrendlineAddLinearForecast = 603,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementTrendlineAddTwoPeriodMovingAverage = 604,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementErrorBarNone = 700,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementErrorBarStandardError = 701,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementErrorBarPercentage = 702,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementErrorBarStandardDeviation = 703,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementLineNone = 800,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementLineDropLine = 801,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementLineHiLoLine = 802,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementLineSeriesLine = 803,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementLineDropHiLoLine = 804,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementUpDownBarsNone = 900,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementUpDownBarsShow = 901,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPlotAreaNone = 1000,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementPlotAreaShow = 1001,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementChartWallNone = 1100,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementChartWallShow = 1101,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementChartFloorNone = 1200,
  /// <summary>
  /// Specifies whether and how to display chart elements.
  /// </summary>
  msoElementChartFloorShow = 1201
}
