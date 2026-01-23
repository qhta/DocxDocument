namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a form field in a WordprocessingML document.
/// This class provides properties for form field name, enabled state, calculation behavior, macros, help and status text, and specific form field types (checkbox, drop-down list, text input), enabling advanced configuration and management of interactive form fields within documents.
/// </summary>
public partial class FormFieldData : ModelElement<DXW.FormFieldData>
{
    /// <summary>
    /// Name of the form field, used for identification and referencing within the document.
    /// </summary>
    public string? FormFieldName { get => _FormFieldName; set => UpdateField(ref _FormFieldName, value, nameof(FormFieldName)); }

    private string? _FormFieldName;
    /// <summary>
    /// Indicates whether the form field is enabled for user interaction.
    /// </summary>
    public bool? Enabled { get; set; }
    /// <summary>
    /// Indicates whether calculations should be performed when exiting the form field.
    /// </summary>
    public bool? CalculateOnExit { get; set; }
    /// <summary>
    /// Macro to run when entering the form field.
    /// </summary>
    public string? EntryMacro { get; set; }
    /// <summary>
    /// Macro to run when exiting the form field.
    /// </summary>
    public string? ExitMacro { get; set; }
    /// <summary>
    /// Help text associated with the form field, providing guidance to users.
    /// </summary>
    public HelpText? HelpText { get; set; }
    /// <summary>
    /// Status text associated with the form field, displayed in the status bar or tooltip.
    /// </summary>
    public StatusText? StatusText { get; set; }
    /// <summary>
    /// Checkbox form field properties, if the form field is a checkbox.
    /// </summary>
    public CheckBox? CheckBox { get; set; }
    /// <summary>
    /// Drop-down list form field properties, if the form field is a drop-down list.
    /// </summary>
    public DropDownListFormField? DropDownListFormField { get; set; }
    /// <summary>
    /// Text input form field properties, if the form field is a text input.
    /// </summary>
    public TextInput? TextInput { get; set; }
}