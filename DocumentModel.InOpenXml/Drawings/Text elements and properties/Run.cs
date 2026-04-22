namespace DocumentModel.Drawings;
/// <summary>
///   Represents a text run, including character properties and the text string.
/// </summary>
[OpenXmlType(typeof(DXD.Run))]
[XmlRoot("Run", Namespace = "DocumentModel.Drawings")]
public partial class Run : ModelElement<DXD.Run>
{
  /// <summary>
  /// Initializes a new instance of the Run class.
  /// </summary>
  public Run() : base() { }

  /// <summary>
  /// Initializes a new instance of the Run class using the specified collection.
  /// </summary>
  /// <param name="collection">The collection to be used for initializing the Run instance. The collection must not be null.</param>
  public Run(object collection) : base(collection) { }

  /// <summary>
  ///   Character properties applied to the text run.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Run.RunProperties))]
  public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }
  private RunProperties? _RunProperties;

  /// <summary>
  ///   Text string content of the run.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Run.Text))]
  public string? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }
  private string? _Text;
}