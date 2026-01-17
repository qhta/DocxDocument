namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties of a text box form field in a WordprocessingML document.
/// This interface provides properties for the form field type, default value, maximum length, and formatting, enabling advanced configuration and management of interactive text input fields within forms and documents.
/// </summary>
public class TextInput: ModelElement<DXW.TextInput>
{
  /// <summary>
  /// Type of the text box form field, specifying the kind of input allowed (e.g., regular text, number, date).
  /// </summary>
  public TextBoxFormFieldKind? TextBoxFormFieldType { get; set; }

  /// <summary>
  /// Default string value for the text box form field, displayed when the form is loaded.
  /// </summary>
  public string? DefaultTextBoxFormFieldString { get; set; }

  /// <summary>
  /// Maximum length of input allowed in the text box form field.
  /// </summary>
  public Int16? MaxLength { get; set; }

  /// <summary>
  /// Formatting string for the text box form field, specifying input or display formatting.
  /// </summary>
  public string? Format { get; set; }
}