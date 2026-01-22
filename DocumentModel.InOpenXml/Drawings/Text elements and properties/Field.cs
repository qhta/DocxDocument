namespace DocumentModel.Drawings;
/// <summary>
/// This element specifies a text field which contains generated text that the application should update periodically.
/// Each piece of text when it is generated is given a unique identification number that is used to refer to a specific field.
/// At the time of creation the text field indicates the kind of text that should be used to update this field.
/// This update type is used so that all applications that did not create this text field can still know what kind of text it should be updated with.
/// Thus, the new application can then attach an update type to the text field id for continual updating.
/// </summary>
public partial class Field : ModelElement<DXD.Field>
{
    /// <summary>
    ///   Identifier for the field.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Type of the field.
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    ///   Character properties applied to the field text.
    /// </summary>
    public RunProperties? RunProperties { get; set; }
    /// <summary>
    ///   Paragraph properties applied to the field text.
    /// </summary>
    public ParagraphProperties? ParagraphProperties { get; set; }
    /// <summary>
    ///   Text content of the field.
    /// </summary>
    public string? Text { get; set; }
}