namespace DocumentModel.Drawings;
/// <summary>
/// This element specifies a text field which contains generated text that the application should update periodically.
/// Each piece of text when it is generated is given a unique identification number that is used to refer to a specific field.
/// At the time of creation the text field indicates the kind of text that should be used to update this field.
/// This update type is used so that all applications that did not create this text field can still know what kind of text it should be updated with.
/// Thus, the new application can then attach an update type to the text field id for continual updating.
/// </summary>
[OpenXmlType(typeof(DXD.Field))]
[DataContract]
[XmlRoot("Field", Namespace = "DocumentModel.Drawings")]
public partial class Field : ModelElement<DXD.Field>
{
 /// <summary>
 ///   Identifier for the field.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Field.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;

 /// <summary>
 ///   Type of the field.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Field.Type))]
 public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private string? _Type;

 /// <summary>
 ///   Character properties applied to the field text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Field.RunProperties))]
 public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }
 private RunProperties? _RunProperties;

 /// <summary>
 ///   Paragraph properties applied to the field text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Field.ParagraphProperties))]
 public ParagraphProperties? ParagraphProperties { get => _ParagraphProperties; set => UpdateField(ref _ParagraphProperties, value, nameof(ParagraphProperties)); }
 private ParagraphProperties? _ParagraphProperties;

 /// <summary>
 ///   Text content of the field.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Field.Text))]
 public string? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }
 private string? _Text;
}