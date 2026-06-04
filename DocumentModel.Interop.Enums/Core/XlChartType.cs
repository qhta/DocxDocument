
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcharttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlChartType")]
public enum ChartType
{
  /// <summary>
  /// 3D Clustered Column
  /// </summary>
  [InteropEnumValue("xlColumnClustered")]
  ColumnClustered = 51,
  /// <summary>
  /// 100% Stacked Column
  /// </summary>
  [InteropEnumValue("xlColumnStacked")]
  ColumnStacked = 52,
  /// <summary>
  /// 100% Stacked Column
  /// </summary>
  [InteropEnumValue("xlColumnStacked100")]
  ColumnStacked100 = 53,
  /// <summary>
  /// 3D Clustered Column
  /// </summary>
  [InteropEnumValue("xl3DColumnClustered")]
  ThreeDColumnClustered = 54,
  /// <summary>
  /// 3D Stacked Column
  /// </summary>
  [InteropEnumValue("xl3DColumnStacked")]
  ThreeDColumnStacked = 55,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  [InteropEnumValue("xl3DColumnStacked100")]
  ThreeDColumnStacked100 = 56,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  [InteropEnumValue("xlBarClustered")]
  BarClustered = 57,
  /// <summary>
  /// Stacked Pyramid Bar
  /// </summary>
  [InteropEnumValue("xlBarStacked")]
  BarStacked = 58,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [InteropEnumValue("xlBarStacked100")]
  BarStacked100 = 59,
  /// <summary>
  /// 3D Clustered Bar
  /// </summary>
  [InteropEnumValue("xl3DBarClustered")]
  ThreeDBarClustered = 60,
  /// <summary>
  /// 3D Stacked Bar
  /// </summary>
  [InteropEnumValue("xl3DBarStacked")]
  ThreeDBarStacked = 61,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  [InteropEnumValue("xl3DBarStacked100")]
  ThreeDBarStacked100 = 62,
  /// <summary>
  /// 100% Stacked Line
  /// </summary>
  [InteropEnumValue("xlLineStacked")]
  LineStacked = 63,
  /// <summary>
  /// 100% Stacked Line
  /// </summary>
  [InteropEnumValue("xlLineStacked100")]
  LineStacked100 = 64,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [InteropEnumValue("xlLineMarkers")]
  LineMarkers = 65,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [InteropEnumValue("xlLineMarkersStacked")]
  LineMarkersStacked = 66,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [InteropEnumValue("xlLineMarkersStacked100")]
  LineMarkersStacked100 = 67,
  /// <summary>
  /// Pie of
  /// </summary>
  [InteropEnumValue("xlPieOfPie")]
  PieOfPie = 68,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  [InteropEnumValue("xlPieExploded")]
  PieExploded = 69,
  /// <summary>
  /// Exploded 3D Pie
  /// </summary>
  [InteropEnumValue("xl3DPieExploded")]
  ThreeDPieExploded = 70,
  /// <summary>
  /// Bar of
  /// </summary>
  [InteropEnumValue("xlBarOfPie")]
  BarOfPie = 71,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  [InteropEnumValue("xlXYScatterSmooth")]
  XYScatterSmooth = 72,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  [InteropEnumValue("xlXYScatterSmoothNoMarkers")]
  XYScatterSmoothNoMarkers = 73,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [InteropEnumValue("xlXYScatterLines")]
  XYScatterLines = 74,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [InteropEnumValue("xlXYScatterLinesNoMarkers")]
  XYScatterLinesNoMarkers = 75,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [InteropEnumValue("xlAreaStacked")]
  AreaStacked = 76,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [InteropEnumValue("xlAreaStacked100")]
  AreaStacked100 = 77,
  /// <summary>
  /// 3D Stacked Area
  /// </summary>
  [InteropEnumValue("xl3DAreaStacked")]
  ThreeDAreaStacked = 78,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [InteropEnumValue("xl3DAreaStacked100")]
  ThreeDAreaStacked100 = 79,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  [InteropEnumValue("xlDoughnutExploded")]
  DoughnutExploded = 80,
  /// <summary>
  /// Radar with Data Markers
  /// </summary>
  [InteropEnumValue("xlRadarMarkers")]
  RadarMarkers = 81,
  /// <summary>
  /// Filled
  /// </summary>
  [InteropEnumValue("xlRadarFilled")]
  RadarFilled = 82,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [InteropEnumValue("xlSurface")]
  Surface = 83,
  /// <summary>
  /// 3D Surface (wireframe)
  /// </summary>
  [InteropEnumValue("xlSurfaceWireframe")]
  SurfaceWireframe = 84,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [InteropEnumValue("xlSurfaceTopView")]
  SurfaceTopView = 85,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [InteropEnumValue("xlSurfaceTopViewWireframe")]
  SurfaceTopViewWireframe = 86,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  [InteropEnumValue("xlBubble")]
  Bubble = 15,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  [InteropEnumValue("xlBubble3DEffect")]
  Bubble3DEffect = 87,
  /// <summary>
  /// High- Low-Close
  /// </summary>
  [InteropEnumValue("xlStockHLC")]
  StockHLC = 88,
  /// <summary>
  /// Open- High-Low-Close
  /// </summary>
  [InteropEnumValue("xlStockOHLC")]
  StockOHLC = 89,
  /// <summary>
  /// Volume- High-Low-Close
  /// </summary>
  [InteropEnumValue("xlStockVHLC")]
  StockVHLC = 90,
  /// <summary>
  /// Volume- Open-High-Low-Close
  /// </summary>
  [InteropEnumValue("xlStockVOHLC")]
  StockVOHLC = 91,
  /// <summary>
  /// Clustered Cone Column
  /// </summary>
  [InteropEnumValue("xlCylinderColClustered")]
  CylinderColClustered = 92,
  /// <summary>
  /// 100% Stacked Cylinder Column
  /// </summary>
  [InteropEnumValue("xlCylinderColStacked")]
  CylinderColStacked = 93,
  /// <summary>
  /// 100% Stacked Cylinder Column
  /// </summary>
  [InteropEnumValue("xlCylinderColStacked100")]
  CylinderColStacked100 = 94,
  /// <summary>
  /// Clustered Cylinder Bar
  /// </summary>
  [InteropEnumValue("xlCylinderBarClustered")]
  CylinderBarClustered = 95,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  [InteropEnumValue("xlCylinderBarStacked")]
  CylinderBarStacked = 96,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  [InteropEnumValue("xlCylinderBarStacked100")]
  CylinderBarStacked100 = 97,
  /// <summary>
  /// 3D Cylinder Column
  /// </summary>
  [InteropEnumValue("xlCylinderCol")]
  CylinderCol = 98,
  /// <summary>
  /// Clustered Cone Column
  /// </summary>
  [InteropEnumValue("xlConeColClustered")]
  ConeColClustered = 99,
  /// <summary>
  /// 100% Stacked Cone Column
  /// </summary>
  [InteropEnumValue("xlConeColStacked")]
  ConeColStacked = 100,
  /// <summary>
  /// 100% Stacked Cone Column
  /// </summary>
  [InteropEnumValue("xlConeColStacked100")]
  ConeColStacked100 = 101,
  /// <summary>
  /// Clustered Cone Bar
  /// </summary>
  [InteropEnumValue("xlConeBarClustered")]
  ConeBarClustered = 102,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  [InteropEnumValue("xlConeBarStacked")]
  ConeBarStacked = 103,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  [InteropEnumValue("xlConeBarStacked100")]
  ConeBarStacked100 = 104,
  /// <summary>
  /// 3D Cone
  /// </summary>
  [InteropEnumValue("xlConeCol")]
  ConeCol = 105,
  /// <summary>
  /// Clustered Pyramid Column
  /// </summary>
  [InteropEnumValue("xlPyramidColClustered")]
  PyramidColClustered = 106,
  /// <summary>
  /// 100% Stacked Pyramid Column
  /// </summary>
  [InteropEnumValue("xlPyramidColStacked")]
  PyramidColStacked = 107,
  /// <summary>
  /// 100% Stacked Pyramid Column
  /// </summary>
  [InteropEnumValue("xlPyramidColStacked100")]
  PyramidColStacked100 = 108,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  [InteropEnumValue("xlPyramidBarClustered")]
  PyramidBarClustered = 109,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [InteropEnumValue("xlPyramidBarStacked")]
  PyramidBarStacked = 110,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [InteropEnumValue("xlPyramidBarStacked100")]
  PyramidBarStacked100 = 111,
  /// <summary>
  /// 3D Pyramid Column
  /// </summary>
  [InteropEnumValue("xlPyramidCol")]
  PyramidCol = 112,
  /// <summary>
  /// 3D
  /// </summary>
  [InteropEnumValue("xl3DColumn")]
  ThreeDColumn = -4100,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [InteropEnumValue("xlLine")]
  Line = 4,
  /// <summary>
  /// 3D Line
  /// </summary>
  [InteropEnumValue("xl3DLine")]
  ThreeDLine = -4101,
  /// <summary>
  /// 3D Pie
  /// </summary>
  [InteropEnumValue("xl3DPie")]
  ThreeDPie = -4102,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  [InteropEnumValue("xlPie")]
  Pie = 5,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [InteropEnumValue("xlXYScatter")]
  XYScatter = -4169,
  /// <summary>
  /// 3D Area
  /// </summary>
  [InteropEnumValue("xl3DArea")]
  ThreeDArea = -4098,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [InteropEnumValue("xlArea")]
  Area = 1,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  [InteropEnumValue("xlDoughnut")]
  Doughnut = -4120,
  /// <summary>
  /// Filled
  /// </summary>
  [InteropEnumValue("xlRadar")]
  Radar = -4151,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlCombo")]
  Combo = -4152,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlComboColumnClusteredLine")]
  ComboColumnClusteredLine = 113,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlComboColumnClusteredLineSecondaryAxis")]
  ComboColumnClusteredLineSecondaryAxis = 114,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlComboAreaStackedColumnClustered")]
  ComboAreaStackedColumnClustered = 115,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlOtherCombinations")]
  OtherCombinations = 116,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [InteropEnumValue("xlSuggestedChart")]
  SuggestedChart = -2
}
