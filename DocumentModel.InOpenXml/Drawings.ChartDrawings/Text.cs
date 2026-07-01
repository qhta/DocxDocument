namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the Text Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.Text))]
[DataContract]
[XmlRoot("Text", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class Text : ModelElement<DXO16DCD.Text>
{
  /// <summary>
  /// Specifies the text data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Text.TextData))]
  public TextData? TextData { get => _TextData; set => UpdateField(ref _TextData, value, nameof(TextData)); }

  private TextData? _TextData;
  /// <summary>
  /// Specifies the rich text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.Text.RichTextBody))]
  public RichTextBody? RichTextBody { get => _RichTextBody; set => UpdateField(ref _RichTextBody, value, nameof(RichTextBody)); }

  private RichTextBody? _RichTextBody;
}