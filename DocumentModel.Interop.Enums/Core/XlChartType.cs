
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcharttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlChartType))]
public enum ChartType
{
  /// <summary>
  /// 3D Clustered Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlColumnClustered))]
  ColumnClustered = 51,
  /// <summary>
  /// 100% Stacked Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlColumnStacked))]
  ColumnStacked = 52,
  /// <summary>
  /// 100% Stacked Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlColumnStacked100))]
  ColumnStacked100 = 53,
  /// <summary>
  /// 3D Clustered Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DColumnClustered))]
  ThreeDColumnClustered = 54,
  /// <summary>
  /// 3D Stacked Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DColumnStacked))]
  ThreeDColumnStacked = 55,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DColumnStacked100))]
  ThreeDColumnStacked100 = 56,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlBarClustered))]
  BarClustered = 57,
  /// <summary>
  /// Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlBarStacked))]
  BarStacked = 58,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlBarStacked100))]
  BarStacked100 = 59,
  /// <summary>
  /// 3D Clustered Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DBarClustered))]
  ThreeDBarClustered = 60,
  /// <summary>
  /// 3D Stacked Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DBarStacked))]
  ThreeDBarStacked = 61,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DBarStacked100))]
  ThreeDBarStacked100 = 62,
  /// <summary>
  /// 100% Stacked Line
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlLineStacked))]
  LineStacked = 63,
  /// <summary>
  /// 100% Stacked Line
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlLineStacked100))]
  LineStacked100 = 64,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlLineMarkers))]
  LineMarkers = 65,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlLineMarkersStacked))]
  LineMarkersStacked = 66,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlLineMarkersStacked100))]
  LineMarkersStacked100 = 67,
  /// <summary>
  /// Pie of
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPieOfPie))]
  PieOfPie = 68,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPieExploded))]
  PieExploded = 69,
  /// <summary>
  /// Exploded 3D Pie
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DPieExploded))]
  ThreeDPieExploded = 70,
  /// <summary>
  /// Bar of
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlBarOfPie))]
  BarOfPie = 71,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlXYScatterSmooth))]
  XYScatterSmooth = 72,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlXYScatterSmoothNoMarkers))]
  XYScatterSmoothNoMarkers = 73,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlXYScatterLines))]
  XYScatterLines = 74,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlXYScatterLinesNoMarkers))]
  XYScatterLinesNoMarkers = 75,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlAreaStacked))]
  AreaStacked = 76,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlAreaStacked100))]
  AreaStacked100 = 77,
  /// <summary>
  /// 3D Stacked Area
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DAreaStacked))]
  ThreeDAreaStacked = 78,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DAreaStacked100))]
  ThreeDAreaStacked100 = 79,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlDoughnutExploded))]
  DoughnutExploded = 80,
  /// <summary>
  /// Radar with Data Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlRadarMarkers))]
  RadarMarkers = 81,
  /// <summary>
  /// Filled
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlRadarFilled))]
  RadarFilled = 82,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlSurface))]
  Surface = 83,
  /// <summary>
  /// 3D Surface (wireframe)
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlSurfaceWireframe))]
  SurfaceWireframe = 84,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlSurfaceTopView))]
  SurfaceTopView = 85,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlSurfaceTopViewWireframe))]
  SurfaceTopViewWireframe = 86,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlBubble))]
  Bubble = 15,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlBubble3DEffect))]
  Bubble3DEffect = 87,
  /// <summary>
  /// High- Low-Close
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlStockHLC))]
  StockHLC = 88,
  /// <summary>
  /// Open- High-Low-Close
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlStockOHLC))]
  StockOHLC = 89,
  /// <summary>
  /// Volume- High-Low-Close
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlStockVHLC))]
  StockVHLC = 90,
  /// <summary>
  /// Volume- Open-High-Low-Close
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlStockVOHLC))]
  StockVOHLC = 91,
  /// <summary>
  /// Clustered Cone Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderColClustered))]
  CylinderColClustered = 92,
  /// <summary>
  /// 100% Stacked Cylinder Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderColStacked))]
  CylinderColStacked = 93,
  /// <summary>
  /// 100% Stacked Cylinder Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderColStacked100))]
  CylinderColStacked100 = 94,
  /// <summary>
  /// Clustered Cylinder Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderBarClustered))]
  CylinderBarClustered = 95,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderBarStacked))]
  CylinderBarStacked = 96,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderBarStacked100))]
  CylinderBarStacked100 = 97,
  /// <summary>
  /// 3D Cylinder Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCylinderCol))]
  CylinderCol = 98,
  /// <summary>
  /// Clustered Cone Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeColClustered))]
  ConeColClustered = 99,
  /// <summary>
  /// 100% Stacked Cone Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeColStacked))]
  ConeColStacked = 100,
  /// <summary>
  /// 100% Stacked Cone Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeColStacked100))]
  ConeColStacked100 = 101,
  /// <summary>
  /// Clustered Cone Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeBarClustered))]
  ConeBarClustered = 102,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeBarStacked))]
  ConeBarStacked = 103,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeBarStacked100))]
  ConeBarStacked100 = 104,
  /// <summary>
  /// 3D Cone
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlConeCol))]
  ConeCol = 105,
  /// <summary>
  /// Clustered Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidColClustered))]
  PyramidColClustered = 106,
  /// <summary>
  /// 100% Stacked Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidColStacked))]
  PyramidColStacked = 107,
  /// <summary>
  /// 100% Stacked Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidColStacked100))]
  PyramidColStacked100 = 108,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidBarClustered))]
  PyramidBarClustered = 109,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidBarStacked))]
  PyramidBarStacked = 110,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidBarStacked100))]
  PyramidBarStacked100 = 111,
  /// <summary>
  /// 3D Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPyramidCol))]
  PyramidCol = 112,
  /// <summary>
  /// 3D
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DColumn))]
  ThreeDColumn = -4100,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlLine))]
  Line = 4,
  /// <summary>
  /// 3D Line
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DLine))]
  ThreeDLine = -4101,
  /// <summary>
  /// 3D Pie
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DPie))]
  ThreeDPie = -4102,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlPie))]
  Pie = 5,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlXYScatter))]
  XYScatter = -4169,
  /// <summary>
  /// 3D Area
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xl3DArea))]
  ThreeDArea = -4098,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlArea))]
  Area = 1,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlDoughnut))]
  Doughnut = -4120,
  /// <summary>
  /// Filled
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlRadar))]
  Radar = -4151,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlCombo))]
  Combo = -4152,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlComboColumnClusteredLine))]
  ComboColumnClusteredLine = 113,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlComboColumnClusteredLineSecondaryAxis))]
  ComboColumnClusteredLineSecondaryAxis = 114,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlComboAreaStackedColumnClustered))]
  ComboAreaStackedColumnClustered = 115,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlOtherCombinations))]
  OtherCombinations = 116,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartType.xlSuggestedChart))]
  SuggestedChart = -2
}
