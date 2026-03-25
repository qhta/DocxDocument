
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcharttype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartType
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Clustered Column
  /// </summary>
  ColumnClustered = 51,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked
  /// </summary>
  ColumnStacked = 52,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Column
  /// </summary>
  ColumnStacked100 = 53,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Clustered Column
  /// </summary>
  ThreeDColumnClustered = 54,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Stacked Column
  /// </summary>
  ThreeDColumnStacked = 55,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D 100% Stacked Bar
  /// </summary>
  ThreeDColumnStacked100 = 56,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Bar
  /// </summary>
  BarClustered = 57,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked
  /// </summary>
  BarStacked = 58,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Bar
  /// </summary>
  BarStacked100 = 59,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Clustered Bar
  /// </summary>
  ThreeDBarClustered = 60,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Stacked Bar
  /// </summary>
  ThreeDBarStacked = 61,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D 100% Stacked Bar
  /// </summary>
  ThreeDBarStacked100 = 62,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked
  /// </summary>
  LineStacked = 63,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Line
  /// </summary>
  LineStacked100 = 64,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Line with
  /// </summary>
  LineMarkers = 65,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Line with
  /// Markers
  /// </summary>
  LineMarkersStacked = 66,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Line
  /// with Markers
  /// </summary>
  LineMarkersStacked100 = 67,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Pie of
  /// </summary>
  PieOfPie = 68,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Exploded Pie
  /// </summary>
  PieExploded = 69,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Exploded 3D Pie
  /// </summary>
  ThreeDPieExploded = 70,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Bar of
  /// </summary>
  BarOfPie = 71,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Scatter with
  /// Smoothed Lines
  /// </summary>
  XYScatterSmooth = 72,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Scatter with
  /// Smoothed Lines and No Data Markers
  /// </summary>
  XYScatterSmoothNoMarkers = 73,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Scatter with Lines
  /// </summary>
  XYScatterLines = 74,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Scatter with Lines
  /// and No Data Markers
  /// </summary>
  XYScatterLinesNoMarkers = 75,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked
  /// </summary>
  AreaStacked = 76,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Area
  /// </summary>
  AreaStacked100 = 77,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Stacked Area
  /// </summary>
  ThreeDAreaStacked = 78,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Area
  /// </summary>
  ThreeDAreaStacked100 = 79,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Exploded Doughnut
  /// </summary>
  DoughnutExploded = 80,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Radar with Data
  /// Markers
  /// </summary>
  RadarMarkers = 81,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Filled
  /// </summary>
  RadarFilled = 82,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D
  /// </summary>
  Surface = 83,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 3D Surface
  /// (wireframe)
  /// </summary>
  SurfaceWireframe = 84,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Surface (Top View)
  /// </summary>
  SurfaceTopView = 85,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Surface (Top View
  /// wireframe)
  /// </summary>
  SurfaceTopViewWireframe = 86,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Bubble
  /// </summary>
  Bubble = 15,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Bubble with 3D
  /// effects
  /// </summary>
  Bubble3DEffect = 87,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). High- Low-Close
  /// </summary>
  StockHLC = 88,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Open- High-Low-Close
  /// </summary>
  StockOHLC = 89,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Volume-
  /// High-Low-Close
  /// </summary>
  StockVHLC = 90,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Volume-
  /// Open-High-Low-Close
  /// </summary>
  StockVOHLC = 91,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Cone
  /// Column
  /// </summary>
  CylinderColClustered = 92,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Cylinder Bar
  /// </summary>
  CylinderColStacked = 93,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked
  /// Cylinder Column
  /// </summary>
  CylinderColStacked100 = 94,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Cylinder
  /// Bar
  /// </summary>
  CylinderBarClustered = 95,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Cylinder Bar
  /// </summary>
  CylinderBarStacked = 96,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked
  /// Cylinder Bar
  /// </summary>
  CylinderBarStacked100 = 97,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Cone
  /// Column
  /// </summary>
  CylinderCol = 98,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Cone
  /// Column
  /// </summary>
  ConeColClustered = 99,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Cone Column
  /// </summary>
  ConeColStacked = 100,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Cone
  /// Column
  /// </summary>
  ConeColStacked100 = 101,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Cone Bar
  /// </summary>
  ConeBarClustered = 102,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Cone Bar
  /// </summary>
  ConeBarStacked = 103,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Cone
  /// Bar
  /// </summary>
  ConeBarStacked100 = 104,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Cone
  /// Column
  /// </summary>
  ConeCol = 105,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Pyramid
  /// Column
  /// </summary>
  PyramidColClustered = 106,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Pyramid
  /// Column
  /// </summary>
  PyramidColStacked = 107,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Pyramid
  /// Column
  /// </summary>
  PyramidColStacked100 = 108,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Pyramid
  /// Bar
  /// </summary>
  PyramidBarClustered = 109,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Stacked Pyramid Bar
  /// </summary>
  PyramidBarStacked = 110,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). 100% Stacked Pyramid
  /// Bar
  /// </summary>
  PyramidBarStacked100 = 111,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Clustered Pyramid
  /// Column
  /// </summary>
  PyramidCol = 112,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
  /// type.
  /// </summary>
  ThreeDColumn = -4100,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Line
  /// </summary>
  Line = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
  /// type.
  /// </summary>
  ThreeDLine = -4101,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
  /// type.
  /// </summary>
  ThreeDPie = -4102,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Pie
  /// </summary>
  Pie = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Scatter
  /// </summary>
  XYScatter = -4169,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
  /// type.
  /// </summary>
  ThreeDArea = -4098,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Area
  /// </summary>
  Area = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  Doughnut = -4120,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Radar
  /// </summary>
  Radar = -4151,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  Combo = -4152,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  ComboColumnClusteredLine = 113,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  ComboColumnClusteredLineSecondaryAxis = 114,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  ComboAreaStackedColumnClustered = 115,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  OtherCombinations = 116,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA).
  /// </summary>
  SuggestedChart = -2
}
