
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the chart
/// type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlcharttype?view=office-pia` for Office interop details.
/// </remarks>
public enum ChartType
{
  /// <summary>
  /// 3D Clustered IColumn
  /// </summary>
  ColumnClustered = 51,
  /// <summary>
  /// 100% Stacked IColumn
  /// </summary>
  ColumnStacked = 52,
  /// <summary>
  /// 100% Stacked IColumn
  /// </summary>
  ColumnStacked100 = 53,
  /// <summary>
  /// 3D Clustered IColumn
  /// </summary>
  ThreeDColumnClustered = 54,
  /// <summary>
  /// 3D Stacked IColumn
  /// </summary>
  ThreeDColumnStacked = 55,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  ThreeDColumnStacked100 = 56,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  BarClustered = 57,
  /// <summary>
  /// Stacked Pyramid Bar
  /// </summary>
  BarStacked = 58,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  BarStacked100 = 59,
  /// <summary>
  /// 3D Clustered Bar
  /// </summary>
  ThreeDBarClustered = 60,
  /// <summary>
  /// 3D Stacked Bar
  /// </summary>
  ThreeDBarStacked = 61,
  /// <summary>
  /// 3D 100% Stacked Bar
  /// </summary>
  ThreeDBarStacked100 = 62,
  /// <summary>
  /// 100% Stacked ILine
  /// </summary>
  LineStacked = 63,
  /// <summary>
  /// 100% Stacked ILine
  /// </summary>
  LineStacked100 = 64,
  /// <summary>
  /// 100% Stacked ILine with Markers
  /// </summary>
  LineMarkers = 65,
  /// <summary>
  /// 100% Stacked ILine with Markers
  /// </summary>
  LineMarkersStacked = 66,
  /// <summary>
  /// 100% Stacked ILine with Markers
  /// </summary>
  LineMarkersStacked100 = 67,
  /// <summary>
  /// Pie of
  /// </summary>
  PieOfPie = 68,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  PieExploded = 69,
  /// <summary>
  /// Exploded 3D Pie
  /// </summary>
  ThreeDPieExploded = 70,
  /// <summary>
  /// Bar of
  /// </summary>
  BarOfPie = 71,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  XYScatterSmooth = 72,
  /// <summary>
  /// Scatter with Smoothed Lines and No Data Markers
  /// </summary>
  XYScatterSmoothNoMarkers = 73,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  XYScatterLines = 74,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  XYScatterLinesNoMarkers = 75,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  AreaStacked = 76,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  AreaStacked100 = 77,
  /// <summary>
  /// 3D Stacked Area
  /// </summary>
  ThreeDAreaStacked = 78,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  ThreeDAreaStacked100 = 79,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  DoughnutExploded = 80,
  /// <summary>
  /// Radar with Data Markers
  /// </summary>
  RadarMarkers = 81,
  /// <summary>
  /// Filled
  /// </summary>
  RadarFilled = 82,
  /// <summary>
  /// Surface (Top IView wireframe)
  /// </summary>
  Surface = 83,
  /// <summary>
  /// 3D Surface (wireframe)
  /// </summary>
  SurfaceWireframe = 84,
  /// <summary>
  /// Surface (Top IView wireframe)
  /// </summary>
  SurfaceTopView = 85,
  /// <summary>
  /// Surface (Top IView wireframe)
  /// </summary>
  SurfaceTopViewWireframe = 86,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  Bubble = 15,
  /// <summary>
  /// Bubble with 3D effects
  /// </summary>
  Bubble3DEffect = 87,
  /// <summary>
  /// High- Low-Close
  /// </summary>
  StockHLC = 88,
  /// <summary>
  /// Open- High-Low-Close
  /// </summary>
  StockOHLC = 89,
  /// <summary>
  /// Volume- High-Low-Close
  /// </summary>
  StockVHLC = 90,
  /// <summary>
  /// Volume- Open-High-Low-Close
  /// </summary>
  StockVOHLC = 91,
  /// <summary>
  /// Clustered Cone IColumn
  /// </summary>
  CylinderColClustered = 92,
  /// <summary>
  /// 100% Stacked Cylinder IColumn
  /// </summary>
  CylinderColStacked = 93,
  /// <summary>
  /// 100% Stacked Cylinder IColumn
  /// </summary>
  CylinderColStacked100 = 94,
  /// <summary>
  /// Clustered Cylinder Bar
  /// </summary>
  CylinderBarClustered = 95,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  CylinderBarStacked = 96,
  /// <summary>
  /// 100% Stacked Cylinder Bar
  /// </summary>
  CylinderBarStacked100 = 97,
  /// <summary>
  /// 3D Cylinder IColumn
  /// </summary>
  CylinderCol = 98,
  /// <summary>
  /// Clustered Cone IColumn
  /// </summary>
  ConeColClustered = 99,
  /// <summary>
  /// 100% Stacked Cone IColumn
  /// </summary>
  ConeColStacked = 100,
  /// <summary>
  /// 100% Stacked Cone IColumn
  /// </summary>
  ConeColStacked100 = 101,
  /// <summary>
  /// Clustered Cone Bar
  /// </summary>
  ConeBarClustered = 102,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  ConeBarStacked = 103,
  /// <summary>
  /// 100% Stacked Cone Bar
  /// </summary>
  ConeBarStacked100 = 104,
  /// <summary>
  /// 3D Cone
  /// </summary>
  ConeCol = 105,
  /// <summary>
  /// Clustered Pyramid IColumn
  /// </summary>
  PyramidColClustered = 106,
  /// <summary>
  /// 100% Stacked Pyramid IColumn
  /// </summary>
  PyramidColStacked = 107,
  /// <summary>
  /// 100% Stacked Pyramid IColumn
  /// </summary>
  PyramidColStacked100 = 108,
  /// <summary>
  /// Clustered Pyramid Bar
  /// </summary>
  PyramidBarClustered = 109,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  PyramidBarStacked = 110,
  /// <summary>
  /// 100% Stacked Pyramid Bar
  /// </summary>
  PyramidBarStacked100 = 111,
  /// <summary>
  /// 3D Pyramid IColumn
  /// </summary>
  PyramidCol = 112,
  /// <summary>
  /// 3D
  /// </summary>
  ThreeDColumn = -4100,
  /// <summary>
  /// 100% Stacked ILine with Markers
  /// </summary>
  ILine = 4,
  /// <summary>
  /// 3D ILine
  /// </summary>
  ThreeDLine = -4101,
  /// <summary>
  /// 3D Pie
  /// </summary>
  ThreeDPie = -4102,
  /// <summary>
  /// Exploded Pie
  /// </summary>
  Pie = 5,
  /// <summary>
  /// Scatter with Lines and No Data Markers
  /// </summary>
  XYScatter = -4169,
  /// <summary>
  /// 3D Area
  /// </summary>
  ThreeDArea = -4098,
  /// <summary>
  /// 100% Stacked Area
  /// </summary>
  Area = 1,
  /// <summary>
  /// Exploded Doughnut
  /// </summary>
  Doughnut = -4120,
  /// <summary>
  /// Filled
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

