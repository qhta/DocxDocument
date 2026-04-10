namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents embedded data stored directly within a chart definition.
/// </summary>
/// <remarks>
///   This class defines the structure for chart data that is
///   stored directly within the chart rather than referenced from external sources. Embedded data makes the
///   chart self-contained and portable, eliminating dependencies on external data sources such as spreadsheets
///   or databases. The data is organized into dimensions: numeric dimensions for continuous values (such as
///   sales figures, measurements, or quantities) and string dimensions for categorical information (such as
///   labels, dates, or category names). Each data instance has a unique identifier that distinguishes it
///   within the chart's data structure. This embedded approach is ideal for static charts or when portability
///   is more important than dynamic data updates. Unlike external data sources referenced through
///   <see cref = "ChartData.ExternalData"/>, embedded data must be manually updated if the underlying values
///   change. The dimensional structure supports various chart types including bar charts, line charts,
///   scatter plots, and more complex visualizations that require both numeric and categorical data.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.Data))]
[XmlRoot("Data", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class Data : ModelElement<DXO16DCD.Data>
{
 /// <summary>
 /// Specifies the unique identifier of the element.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.Data.Id))]
 public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private UInt32? _Id;
 /// <summary>
 /// Specifies the numeric dimension.
 /// </summary>
 public NumericDimension? NumericDimension { get => _NumericDimension; set => UpdateField(ref _NumericDimension, value, nameof(NumericDimension)); }

 private NumericDimension? _NumericDimension;
 /// <summary>
 /// Specifies the string dimension.
 /// </summary>
 public StringDimension? StringDimension { get => _StringDimension; set => UpdateField(ref _StringDimension, value, nameof(StringDimension)); }

 private StringDimension? _StringDimension;
 /// <summary>
 /// Specifies the extension list.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}