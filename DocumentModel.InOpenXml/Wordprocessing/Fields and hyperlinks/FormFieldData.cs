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
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public string? FormFieldName { get => _FormFieldName; set => UpdateField(ref _FormFieldName, value, nameof(FormFieldName)); }

    private string? _FormFieldName;
    /// <summary>
    /// Indicates whether the form field is enabled for user interaction.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public bool? Enabled { get => _Enabled; set => UpdateField(ref _Enabled, value, nameof(Enabled)); }

    private bool? _Enabled;
    /// <summary>
    /// Indicates whether calculations should be performed when exiting the form field.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public bool? CalculateOnExit { get => _CalculateOnExit; set => UpdateField(ref _CalculateOnExit, value, nameof(CalculateOnExit)); }

    private bool? _CalculateOnExit;
    /// <summary>
    /// Macro to run when entering the form field.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public string? EntryMacro { get => _EntryMacro; set => UpdateField(ref _EntryMacro, value, nameof(EntryMacro)); }

    private string? _EntryMacro;
    /// <summary>
    /// Macro to run when exiting the form field.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public string? ExitMacro { get => _ExitMacro; set => UpdateField(ref _ExitMacro, value, nameof(ExitMacro)); }

    private string? _ExitMacro;
    /// <summary>
    /// Help text associated with the form field, providing guidance to users.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public HelpText? HelpText { get => _HelpText; set => UpdateField(ref _HelpText, value, nameof(HelpText)); }

    private HelpText? _HelpText;
    /// <summary>
    /// Status text associated with the form field, displayed in the status bar or tooltip.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public StatusText? StatusText { get => _StatusText; set => UpdateField(ref _StatusText, value, nameof(StatusText)); }

    private StatusText? _StatusText;
    /// <summary>
    /// Checkbox form field properties, if the form field is a checkbox.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public CheckBox? CheckBox { get => _CheckBox; set => UpdateField(ref _CheckBox, value, nameof(CheckBox)); }

    private CheckBox? _CheckBox;
    /// <summary>
    /// Drop-down list form field properties, if the form field is a drop-down list.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public DropDownListFormField? DropDownListFormField { get => _DropDownListFormField; set => UpdateField(ref _DropDownListFormField, value, nameof(DropDownListFormField)); }

    private DropDownListFormField? _DropDownListFormField;
    /// <summary>
    /// Text input form field properties, if the form field is a text input.
    /// </summary>
    [OpenXmlElement(typeof(DXW.FormFieldData))]
    public TextInput? TextInput { get => _TextInput; set => UpdateField(ref _TextInput, value, nameof(TextInput)); }

    private TextInput? _TextInput;
}