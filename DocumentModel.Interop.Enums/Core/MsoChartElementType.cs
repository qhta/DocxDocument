namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether and how to display chart elements.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msochartelementtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoChartElementType))]
public enum ChartElementType
{
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartTitleNone))]
  ChartTitleNone = 0,
  /// <summary>
  /// Display title as centered overlay.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartTitleCenteredOverlay))]
  ChartTitleCenteredOverlay = 1,
  /// <summary>
  /// Display title above chart.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartTitleAboveChart))]
  ChartTitleAboveChart = 2,
  /// <summary>
  /// Do not display legend.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendNone))]
  LegendNone = 100,
  /// <summary>
  /// Display legend at the right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendRight))]
  LegendRight = 101,
  /// <summary>
  /// Display legend at the top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendTop))]
  LegendTop = 102,
  /// <summary>
  /// Display legend on the left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendLeft))]
  LegendLeft = 103,
  /// <summary>
  /// Display legend at the bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendBottom))]
  LegendBottom = 104,
  /// <summary>
  /// Overlay legend at the right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendRightOverlay))]
  LegendRightOverlay = 105,
  /// <summary>
  /// Overlay legend at the left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLegendLeftOverlay))]
  LegendLeftOverlay = 106,
  /// <summary>
  /// Do not display data label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelNone))]
  DataLabelNone = 200,
  /// <summary>
  /// Display data label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelShow))]
  DataLabelShow = 201,
  /// <summary>
  /// Display data label in center.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelCenter))]
  DataLabelCenter = 202,
  /// <summary>
  /// Display data label inside at the end.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelInsideEnd))]
  DataLabelInsideEnd = 203,
  /// <summary>
  /// Display data label inside at the base.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelInsideBase))]
  DataLabelInsideBase = 204,
  /// <summary>
  /// Display data label outside at the end.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelOutSideEnd))]
  DataLabelOutSideEnd = 205,
  /// <summary>
  /// Display data label to the left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelLeft))]
  DataLabelLeft = 206,
  /// <summary>
  /// Display data label to the right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelRight))]
  DataLabelRight = 207,
  /// <summary>
  /// Display data label at the top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelTop))]
  DataLabelTop = 208,
  /// <summary>
  /// Display data label at bottom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelBottom))]
  DataLabelBottom = 209,
  /// <summary>
  /// Use best fit for data label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelBestFit))]
  DataLabelBestFit = 210,
  /// <summary>
  /// Display data label as a callout.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataLabelCallout))]
  DataLabelCallout = 211,
  /// <summary>
  /// Do not display primary category axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisTitleNone))]
  PrimaryCategoryAxisTitleNone = 300,
  /// <summary>
  /// Display primary category axis title adjacent to the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisTitleAdjacentToAxis))]
  PrimaryCategoryAxisTitleAdjacentToAxis = 301,
  /// <summary>
  /// Display primary category axis title below the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisTitleBelowAxis))]
  PrimaryCategoryAxisTitleBelowAxis = 302,
  /// <summary>
  /// Rotate primary category axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisTitleRotated))]
  PrimaryCategoryAxisTitleRotated = 303,
  /// <summary>
  /// Display primary category axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisTitleVertical))]
  PrimaryCategoryAxisTitleVertical = 304,
  /// <summary>
  /// Display primary category axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisTitleHorizontal))]
  PrimaryCategoryAxisTitleHorizontal = 305,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisTitleNone))]
  PrimaryValueAxisTitleNone = 306,
  /// <summary>
  /// Place primary value axis title adjacent to the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisTitleAdjacentToAxis))]
  PrimaryValueAxisTitleAdjacentToAxis = 306,
  /// <summary>
  /// Place primary value axis title below the axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisTitleBelowAxis))]
  PrimaryValueAxisTitleBelowAxis = 308,
  /// <summary>
  /// Rotate primary value axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisTitleRotated))]
  PrimaryValueAxisTitleRotated = 309,
  /// <summary>
  /// Display primary value axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisTitleVertical))]
  PrimaryValueAxisTitleVertical = 310,
  /// <summary>
  /// Display primary value axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisTitleHorizontal))]
  PrimaryValueAxisTitleHorizontal = 311,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisTitleNone))]
  SecondaryCategoryAxisTitleNone = 312,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisTitleAdjacentToAxis))]
  SecondaryCategoryAxisTitleAdjacentToAxis = 313,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisTitleBelowAxis))]
  SecondaryCategoryAxisTitleBelowAxis = 314,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisTitleRotated))]
  SecondaryCategoryAxisTitleRotated = 315,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisTitleVertical))]
  SecondaryCategoryAxisTitleVertical = 316,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisTitleHorizontal))]
  SecondaryCategoryAxisTitleHorizontal = 317,
  /// <summary>
  /// Do not display secondary category axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisTitleNone))]
  SecondaryValueAxisTitleNone = 318,
  /// <summary>
  /// Display secondary category axis title adjacent to axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisTitleAdjacentToAxis))]
  SecondaryValueAxisTitleAdjacentToAxis = 319,
  /// <summary>
  /// Display secondary category axis title below axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisTitleBelowAxis))]
  SecondaryValueAxisTitleBelowAxis = 320,
  /// <summary>
  /// Rotate secondary category axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisTitleRotated))]
  SecondaryValueAxisTitleRotated = 321,
  /// <summary>
  /// Display secondary category axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisTitleVertical))]
  SecondaryValueAxisTitleVertical = 322,
  /// <summary>
  /// Display secondary category axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisTitleHorizontal))]
  SecondaryValueAxisTitleHorizontal = 323,
  /// <summary>
  /// Do not display series axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisTitleNone))]
  SeriesAxisTitleNone = 324,
  /// <summary>
  /// Rotate series axis title.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisTitleRotated))]
  SeriesAxisTitleRotated = 325,
  /// <summary>
  /// Display series axis title vertically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisTitleVertical))]
  SeriesAxisTitleVertical = 326,
  /// <summary>
  /// Display series axis title horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisTitleHorizontal))]
  SeriesAxisTitleHorizontal = 327,
  /// <summary>
  /// Do not display grid lines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueGridLinesNone))]
  PrimaryValueGridLinesNone = 328,
  /// <summary>
  /// Display minor gridlines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueGridLinesMinor))]
  PrimaryValueGridLinesMinor = 329,
  /// <summary>
  /// Display major gridlines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueGridLinesMajor))]
  PrimaryValueGridLinesMajor = 330,
  /// <summary>
  /// Display both major and minor gridlines along primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueGridLinesMinorMajor))]
  PrimaryValueGridLinesMinorMajor = 331,
  /// <summary>
  /// Do not display grid lines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryGridLinesNone))]
  PrimaryCategoryGridLinesNone = 332,
  /// <summary>
  /// Display minor gridlines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryGridLinesMinor))]
  PrimaryCategoryGridLinesMinor = 333,
  /// <summary>
  /// Display major gridlines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryGridLinesMajor))]
  PrimaryCategoryGridLinesMajor = 334,
  /// <summary>
  /// Display both major and minor gridlines along primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryGridLinesMinorMajor))]
  PrimaryCategoryGridLinesMinorMajor = 335,
  /// <summary>
  /// Do not display gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueGridLinesNone))]
  SecondaryValueGridLinesNone = 336,
  /// <summary>
  /// Display minor gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueGridLinesMinor))]
  SecondaryValueGridLinesMinor = 337,
  /// <summary>
  /// Display major gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueGridLinesMajor))]
  SecondaryValueGridLinesMajor = 338,
  /// <summary>
  /// Display both major and minor gridlines along secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueGridLinesMinorMajor))]
  SecondaryValueGridLinesMinorMajor = 339,
  /// <summary>
  /// Do not display grid lines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryGridLinesNone))]
  SecondaryCategoryGridLinesNone = 340,
  /// <summary>
  /// Display minor gridlines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryGridLinesMinor))]
  SecondaryCategoryGridLinesMinor = 341,
  /// <summary>
  /// Display major gridlines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryGridLinesMajor))]
  SecondaryCategoryGridLinesMajor = 342,
  /// <summary>
  /// Display both major and minor gridlines along secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryGridLinesMinorMajor))]
  SecondaryCategoryGridLinesMinorMajor = 343,
  /// <summary>
  /// Do not display gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisGridLinesNone))]
  SeriesAxisGridLinesNone = 344,
  /// <summary>
  /// Display minor gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisGridLinesMinor))]
  SeriesAxisGridLinesMinor = 345,
  /// <summary>
  /// Display major gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisGridLinesMajor))]
  SeriesAxisGridLinesMajor = 346,
  /// <summary>
  /// Display both major and minor gridlines along series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisGridLinesMinorMajor))]
  SeriesAxisGridLinesMinorMajor = 347,
  /// <summary>
  /// Do not display primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisNone))]
  PrimaryCategoryAxisNone = 348,
  /// <summary>
  /// Show primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisShow))]
  PrimaryCategoryAxisShow = 349,
  /// <summary>
  /// Display primary category axis without labels.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisWithoutLabels))]
  PrimaryCategoryAxisWithoutLabels = 350,
  /// <summary>
  /// Reverse primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisReverse))]
  PrimaryCategoryAxisReverse = 351,
  /// <summary>
  /// Do not display primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisNone))]
  PrimaryValueAxisNone = 352,
  /// <summary>
  /// Show primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisShow))]
  PrimaryValueAxisShow = 353,
  /// <summary>
  /// Use thousands for primary value axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisThousands))]
  PrimaryValueAxisThousands = 354,
  /// <summary>
  /// Use millions for primary value axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisMillions))]
  PrimaryValueAxisMillions = 355,
  /// <summary>
  /// Use billions for primary value axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisBillions))]
  PrimaryValueAxisBillions = 356,
  /// <summary>
  /// Use log scale for primary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryValueAxisLogScale))]
  PrimaryValueAxisLogScale = 357,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisNone))]
  SecondaryCategoryAxisNone = 358,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisShow))]
  SecondaryCategoryAxisShow = 359,
  /// <summary>
  /// Display secondary category axis without labels.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisWithoutLabels))]
  SecondaryCategoryAxisWithoutLabels = 360,
  /// <summary>
  /// Reverse secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisReverse))]
  SecondaryCategoryAxisReverse = 361,
  /// <summary>
  /// Do not display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisNone))]
  SecondaryValueAxisNone = 362,
  /// <summary>
  /// Display secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisShow))]
  SecondaryValueAxisShow = 363,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisThousands))]
  SecondaryValueAxisThousands = 364,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisMillions))]
  SecondaryValueAxisMillions = 365,
  /// <summary>
  /// Use billions for secondary value axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisBillions))]
  SecondaryValueAxisBillions = 366,
  /// <summary>
  /// Use log scale for secondary value axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryValueAxisLogScale))]
  SecondaryValueAxisLogScale = 367,
  /// <summary>
  /// Do not display series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisNone))]
  SeriesAxisNone = 368,
  /// <summary>
  /// Display series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisShow))]
  SeriesAxisShow = 369,
  /// <summary>
  /// Display series axis title without labeling.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisWithoutLabeling))]
  SeriesAxisWithoutLabeling = 370,
  /// <summary>
  /// Reverse series axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSeriesAxisReverse))]
  SeriesAxisReverse = 371,
  /// <summary>
  /// Use thousands for primary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisThousands))]
  PrimaryCategoryAxisThousands = 372,
  /// <summary>
  /// Use millions for primary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisMillions))]
  PrimaryCategoryAxisMillions = 373,
  /// <summary>
  /// Use billions for primary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisBillions))]
  PrimaryCategoryAxisBillions = 374,
  /// <summary>
  /// Use log scale for primary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPrimaryCategoryAxisLogScale))]
  PrimaryCategoryAxisLogScale = 375,
  /// <summary>
  /// Use thousands for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisThousands))]
  SecondaryCategoryAxisThousands = 376,
  /// <summary>
  /// Use millions for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisMillions))]
  SecondaryCategoryAxisMillions = 377,
  /// <summary>
  /// Use billions for secondary category axis units.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisBillions))]
  SecondaryCategoryAxisBillions = 378,
  /// <summary>
  /// Use log scale for secondary category axis.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementSecondaryCategoryAxisLogScale))]
  SecondaryCategoryAxisLogScale = 379,
  /// <summary>
  /// Do not display data table.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataTableNone))]
  DataTableNone = 500,
  /// <summary>
  /// Display data table.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataTableShow))]
  DataTableShow = 501,
  /// <summary>
  /// Display data table with legend keys.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementDataTableWithLegendKeys))]
  DataTableWithLegendKeys = 502,
  /// <summary>
  /// Do not display trendline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementTrendlineNone))]
  TrendlineNone = 600,
  /// <summary>
  /// Add a linear trendline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementTrendlineAddLinear))]
  TrendlineAddLinear = 601,
  /// <summary>
  /// Add an exponential trendline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementTrendlineAddExponential))]
  TrendlineAddExponential = 602,
  /// <summary>
  /// Add a linear forecast.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementTrendlineAddLinearForecast))]
  TrendlineAddLinearForecast = 603,
  /// <summary>
  /// Add a two-period moving average.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementTrendlineAddTwoPeriodMovingAverage))]
  TrendlineAddTwoPeriodMovingAverage = 604,
  /// <summary>
  /// Do not display error bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementErrorBarNone))]
  ErrorBarNone = 700,
  /// <summary>
  /// Display standard error bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementErrorBarStandardError))]
  ErrorBarStandardError = 701,
  /// <summary>
  /// Display percentage error bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementErrorBarPercentage))]
  ErrorBarPercentage = 702,
  /// <summary>
  /// Display standard deviation error bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementErrorBarStandardDeviation))]
  ErrorBarStandardDeviation = 703,
  /// <summary>
  /// Do not display line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLineNone))]
  LineNone = 800,
  /// <summary>
  /// Display drop line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLineDropLine))]
  LineDropLine = 801,
  /// <summary>
  /// Display high/low line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLineHiLoLine))]
  LineHiLoLine = 802,
  /// <summary>
  /// Display series line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLineSeriesLine))]
  LineSeriesLine = 803,
  /// <summary>
  /// Display drop high/low line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementLineDropHiLoLine))]
  LineDropHiLoLine = 804,
  /// <summary>
  /// Do not display up/down bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementUpDownBarsNone))]
  UpDownBarsNone = 900,
  /// <summary>
  /// Display up/down bars.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementUpDownBarsShow))]
  UpDownBarsShow = 901,
  /// <summary>
  /// Do not display plot area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPlotAreaNone))]
  PlotAreaNone = 1000,
  /// <summary>
  /// Display plot area.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementPlotAreaShow))]
  PlotAreaShow = 1001,
  /// <summary>
  /// Do not display chart wall.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartWallNone))]
  ChartWallNone = 1100,
  /// <summary>
  /// Display chart wall.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartWallShow))]
  ChartWallShow = 1101,
  /// <summary>
  /// Do not display chart floor.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartFloorNone))]
  ChartFloorNone = 1200,
  /// <summary>
  /// Display chart floor.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoChartElementType.msoElementChartFloorShow))]
  ChartFloorShow = 1201
}
