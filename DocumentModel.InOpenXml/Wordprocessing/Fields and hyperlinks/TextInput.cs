namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a text box form field in a WordprocessingML document.
/// This class provides properties for the form field type, default value, maximum length, and formatting, enabling advanced configuration and management of interactive text input fields within forms and documents.
/// </summary>
public partial class TextInput : ModelElement<DXW.TextInput>
{
    /// <summary>
    /// Type of the text box form field, specifying the kind of input allowed (e.g., regular text, number, date).
    /// </summary>
    public TextBoxFormFieldKind? TextBoxFormFieldType { get => _TextBoxFormFieldType; set => UpdateField(ref _TextBoxFormFieldType, value, nameof(TextBoxFormFieldType)); }

    private TextBoxFormFieldKind? _TextBoxFormFieldType;
    /// <summary>
    /// Default string value for the text box form field, displayed when the form is loaded.
    /// </summary>
    public string? DefaultTextBoxFormFieldString { get => _DefaultTextBoxFormFieldString; set => UpdateField(ref _DefaultTextBoxFormFieldString, value, nameof(DefaultTextBoxFormFieldString)); }

    private string? _DefaultTextBoxFormFieldString;
    /// <summary>
    /// Maximum length of input allowed in the text box form field.
    /// </summary>
    public Int16? MaxLength { get => _MaxLength; set => UpdateField(ref _MaxLength, value, nameof(MaxLength)); }

    private Int16? _MaxLength;
    /// <summary>
    /// Formatting string for the text box form field, specifying input or display formatting.
    /// </summary>
    public string? Format { get => _Format; set => UpdateField(ref _Format, value, nameof(Format)); }

    private string? _Format;
}