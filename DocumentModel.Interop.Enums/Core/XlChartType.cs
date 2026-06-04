
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcharttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlChartType")]
public enum ChartType
{
  /// <summary>
  /// 3D Clustered Column
  /// </summary>
  [OfficeInteropEnumValue("xlColumnClustered")]
  ColumnClustered = 51,
  /// <summary>
  /// 100% Stacked Column
  /// </summary>
  [OfficeInteropEnumValue("xlColumnStacked")]
  ColumnStacked = 52,
  /// <summary>
  /// 100% Stacked Column
  /// </summary>
  [OfficeInteropEnumValue("xlColumnStacked100")]
  ColumnStacked100 = 53,
  /// <summary>
  /// 3D Clustered Column
  /// </summary>
  [OfficeInteropEnumValue("xl3DColumnClustered")]
  ThreeDColumnClustered = 54,
  /// <summary>
  /// 3D Stacked Column
  /// </summary>
  [OfficeInteropEnumValue("xl3DColumnStacked")]
  ThreeDColumnStacked = 55,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  [OfficeInteropEnumValue("xl3DColumnStacked100")]
  ThreeDColumnStacked100 = 56,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue("xlBarClustered")]
  BarClustered = 57,
  /// <summary>
  /// Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue("xlBarStacked")]
  BarStacked = 58,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue("xlBarStacked100")]
  BarStacked100 = 59,
  /// <summary>
  /// 3D Clustered Bar
  /// </summary>
  [OfficeInteropEnumValue("xl3DBarClustered")]
  ThreeDBarClustered = 60,
  /// <summary>
  /// 3D Stacked Bar
  /// </summary>
  [OfficeInteropEnumValue("xl3DBarStacked")]
  ThreeDBarStacked = 61,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  [OfficeInteropEnumValue("xl3DBarStacked100")]
  ThreeDBarStacked100 = 62,
  /// <summary>
  /// 100% Stacked Line
  /// </summary>
  [OfficeInteropEnumValue("xlLineStacked")]
  LineStacked = 63,
  /// <summary>
  /// 100% Stacked Line
  /// </summary>
  [OfficeInteropEnumValue("xlLineStacked100")]
  LineStacked100 = 64,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue("xlLineMarkers")]
  LineMarkers = 65,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue("xlLineMarkersStacked")]
  LineMarkersStacked = 66,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue("xlLineMarkersStacked100")]
  LineMarkersStacked100 = 67,
  /// <summary>
  /// Pie of
  /// </summary>
  [OfficeInteropEnumValue("xlPieOfPie")]
  PieOfPie = 68,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  [OfficeInteropEnumValue("xlPieExploded")]
  PieExploded = 69,
  /// <summary>
  /// Exploded 3D Pie
  /// </summary>
  [OfficeInteropEnumValue("xl3DPieExploded")]
  ThreeDPieExploded = 70,
  /// <summary>
  /// Bar of
  /// </summary>
  [OfficeInteropEnumValue("xlBarOfPie")]
  BarOfPie = 71,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue("xlXYScatterSmooth")]
  XYScatterSmooth = 72,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue("xlXYScatterSmoothNoMarkers")]
  XYScatterSmoothNoMarkers = 73,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue("xlXYScatterLines")]
  XYScatterLines = 74,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue("xlXYScatterLinesNoMarkers")]
  XYScatterLinesNoMarkers = 75,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue("xlAreaStacked")]
  AreaStacked = 76,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue("xlAreaStacked100")]
  AreaStacked100 = 77,
  /// <summary>
  /// 3D Stacked Area
  /// </summary>
  [OfficeInteropEnumValue("xl3DAreaStacked")]
  ThreeDAreaStacked = 78,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue("xl3DAreaStacked100")]
  ThreeDAreaStacked100 = 79,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  [OfficeInteropEnumValue("xlDoughnutExploded")]
  DoughnutExploded = 80,
  /// <summary>
  /// Radar with Data Markers
  /// </summary>
  [OfficeInteropEnumValue("xlRadarMarkers")]
  RadarMarkers = 81,
  /// <summary>
  /// Filled
  /// </summary>
  [OfficeInteropEnumValue("xlRadarFilled")]
  RadarFilled = 82,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [OfficeInteropEnumValue("xlSurface")]
  Surface = 83,
  /// <summary>
  /// 3D Surface (wireframe)
  /// </summary>
  [OfficeInteropEnumValue("xlSurfaceWireframe")]
  SurfaceWireframe = 84,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [OfficeInteropEnumValue("xlSurfaceTopView")]
  SurfaceTopView = 85,
  /// <summary>
  /// Surface (Top View wireframe)
  /// </summary>
  [OfficeInteropEnumValue("xlSurfaceTopViewWireframe")]
  SurfaceTopViewWireframe = 86,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  [OfficeInteropEnumValue("xlBubble")]
  Bubble = 15,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  [OfficeInteropEnumValue("xlBubble3DEffect")]
  Bubble3DEffect = 87,
  /// <summary>
  /// High- Low-Close
  /// </summary>
  [OfficeInteropEnumValue("xlStockHLC")]
  StockHLC = 88,
  /// <summary>
  /// Open- High-Low-Close
  /// </summary>
  [OfficeInteropEnumValue("xlStockOHLC")]
  StockOHLC = 89,
  /// <summary>
  /// Volume- High-Low-Close
  /// </summary>
  [OfficeInteropEnumValue("xlStockVHLC")]
  StockVHLC = 90,
  /// <summary>
  /// Volume- Open-High-Low-Close
  /// </summary>
  [OfficeInteropEnumValue("xlStockVOHLC")]
  StockVOHLC = 91,
  /// <summary>
  /// Clustered Cone Column
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderColClustered")]
  CylinderColClustered = 92,
  /// <summary>
  /// 100% Stacked Cylinder Column
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderColStacked")]
  CylinderColStacked = 93,
  /// <summary>
  /// 100% Stacked Cylinder Column
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderColStacked100")]
  CylinderColStacked100 = 94,
  /// <summary>
  /// Clustered Cylinder Bar
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderBarClustered")]
  CylinderBarClustered = 95,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderBarStacked")]
  CylinderBarStacked = 96,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderBarStacked100")]
  CylinderBarStacked100 = 97,
  /// <summary>
  /// 3D Cylinder Column
  /// </summary>
  [OfficeInteropEnumValue("xlCylinderCol")]
  CylinderCol = 98,
  /// <summary>
  /// Clustered Cone Column
  /// </summary>
  [OfficeInteropEnumValue("xlConeColClustered")]
  ConeColClustered = 99,
  /// <summary>
  /// 100% Stacked Cone Column
  /// </summary>
  [OfficeInteropEnumValue("xlConeColStacked")]
  ConeColStacked = 100,
  /// <summary>
  /// 100% Stacked Cone Column
  /// </summary>
  [OfficeInteropEnumValue("xlConeColStacked100")]
  ConeColStacked100 = 101,
  /// <summary>
  /// Clustered Cone Bar
  /// </summary>
  [OfficeInteropEnumValue("xlConeBarClustered")]
  ConeBarClustered = 102,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  [OfficeInteropEnumValue("xlConeBarStacked")]
  ConeBarStacked = 103,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  [OfficeInteropEnumValue("xlConeBarStacked100")]
  ConeBarStacked100 = 104,
  /// <summary>
  /// 3D Cone
  /// </summary>
  [OfficeInteropEnumValue("xlConeCol")]
  ConeCol = 105,
  /// <summary>
  /// Clustered Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidColClustered")]
  PyramidColClustered = 106,
  /// <summary>
  /// 100% Stacked Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidColStacked")]
  PyramidColStacked = 107,
  /// <summary>
  /// 100% Stacked Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidColStacked100")]
  PyramidColStacked100 = 108,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidBarClustered")]
  PyramidBarClustered = 109,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidBarStacked")]
  PyramidBarStacked = 110,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidBarStacked100")]
  PyramidBarStacked100 = 111,
  /// <summary>
  /// 3D Pyramid Column
  /// </summary>
  [OfficeInteropEnumValue("xlPyramidCol")]
  PyramidCol = 112,
  /// <summary>
  /// 3D
  /// </summary>
  [OfficeInteropEnumValue("xl3DColumn")]
  ThreeDColumn = -4100,
  /// <summary>
  /// 100% Stacked Line with Markers
  /// </summary>
  [OfficeInteropEnumValue("xlLine")]
  Line = 4,
  /// <summary>
  /// 3D Line
  /// </summary>
  [OfficeInteropEnumValue("xl3DLine")]
  ThreeDLine = -4101,
  /// <summary>
  /// 3D Pie
  /// </summary>
  [OfficeInteropEnumValue("xl3DPie")]
  ThreeDPie = -4102,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  [OfficeInteropEnumValue("xlPie")]
  Pie = 5,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  [OfficeInteropEnumValue("xlXYScatter")]
  XYScatter = -4169,
  /// <summary>
  /// 3D Area
  /// </summary>
  [OfficeInteropEnumValue("xl3DArea")]
  ThreeDArea = -4098,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  [OfficeInteropEnumValue("xlArea")]
  Area = 1,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  [OfficeInteropEnumValue("xlDoughnut")]
  Doughnut = -4120,
  /// <summary>
  /// Filled
  /// </summary>
  [OfficeInteropEnumValue("xlRadar")]
  Radar = -4151,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlCombo")]
  Combo = -4152,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlComboColumnClusteredLine")]
  ComboColumnClusteredLine = 113,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlComboColumnClusteredLineSecondaryAxis")]
  ComboColumnClusteredLineSecondaryAxis = 114,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlComboAreaStackedColumnClustered")]
  ComboAreaStackedColumnClustered = 115,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlOtherCombinations")]
  OtherCombinations = 116,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  [OfficeInteropEnumValue("xlSuggestedChart")]
  SuggestedChart = -2
}
