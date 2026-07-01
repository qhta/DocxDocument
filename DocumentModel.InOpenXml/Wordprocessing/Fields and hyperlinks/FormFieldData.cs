namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a form field in a WordprocessingML document.
/// This class provides properties for form field name, enabled state, calculation behavior, macros, help and status text, and specific form field types (checkbox, drop-down list, text input), enabling advanced configuration and management of interactive form fields within documents.
/// </summary>
[OpenXmlType(typeof(DXW.FormFieldData))]
[XmlRoot("FormFieldData", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess(true)]
public partial class FormFieldData : ModelElement<DXW.FormFieldData>
{
  /// <summary>
  /// Name of the form field, used for identification and referencing within the document.
  /// </summary>
  [OpenXmlElement(typeof(DXW.FormFieldName))]
  public string? FormFieldName 
  {
    get => _FormFieldName ??= GetElement<string?, DXW.FormFieldName>(GetUpdatableElement());
    set => UpdateField(ref _FormFieldName, value, nameof(FormFieldName));
  }
  private string? _FormFieldName;

  /// <summary>
  /// Indicates whether the form field is enabled for user interaction.
  /// </summary>
  [OpenXmlElement(typeof(DXW.Enabled))]
  public bool? Enabled 
  {
    get => _Enabled ??= GetElement<bool?, DXW.Enabled>(GetUpdatableElement());
    set => UpdateField(ref _Enabled, value, nameof(Enabled));
  }
  private bool? _Enabled;

  /// <summary>
  /// Indicates whether calculations should be performed when exiting the form field.
  /// </summary>
  [OpenXmlElement(typeof(DXW.CalculateOnExit))]
  public bool? CalculateOnExit 
  {
    get => _CalculateOnExit ??= GetElement<bool?, DXW.CalculateOnExit>(GetUpdatableElement());
    set => UpdateField(ref _CalculateOnExit, value, nameof(CalculateOnExit));
  }
  private bool? _CalculateOnExit;

  /// <summary>
  /// Macro to run when entering the form field.
  /// </summary>
  [OpenXmlElement(typeof(DXW.EntryMacro))]
  public string? EntryMacro 
  {
    get => _EntryMacro ??= GetElement<string?, DXW.EntryMacro>(GetUpdatableElement());
    set => UpdateField(ref _EntryMacro, value, nameof(EntryMacro));
  }
  private string? _EntryMacro;

  /// <summary>
  /// Macro to run when exiting the form field.
  /// </summary>
  [OpenXmlElement(typeof(DXW.ExitMacro))]
  public string? ExitMacro 
  {
    get => _ExitMacro ??= GetElement<string?, DXW.ExitMacro>(GetUpdatableElement());
    set => UpdateField(ref _ExitMacro, value, nameof(ExitMacro));
  }
  private string? _ExitMacro;

  /// <summary>
  /// Help text associated with the form field, providing guidance to users.
  /// </summary>
  [OpenXmlElement(typeof(DXW.HelpText))]
  public HelpText? HelpText
  {
    get => _HelpText ??= GetElement<HelpText?, DXW.HelpText>(GetUpdatableElement());
    set => UpdateField(ref _HelpText, value, nameof(HelpText));
  }
  private HelpText? _HelpText;

  /// <summary>
  /// Status text associated with the form field, displayed in the status bar or tooltip.
  /// </summary>
  [OpenXmlElement(typeof(DXW.StatusText))]
  public StatusText? StatusText
  {
    get => _StatusText ??= GetElement<StatusText?, DXW.StatusText>(GetUpdatableElement());
    set => UpdateField(ref _StatusText, value, nameof(StatusText));
  }
  private StatusText? _StatusText;

  /// <summary>
  /// Checkbox form field properties, if the form field is a checkbox.
  /// </summary>
  [OpenXmlElement(typeof(DXW.CheckBox))]
  public CheckBox? CheckBox
  {
    get => _CheckBox ??= GetElement<CheckBox?, DXW.CheckBox>(GetUpdatableElement());
    set => UpdateField(ref _CheckBox, value, nameof(CheckBox));
  }
  private CheckBox? _CheckBox;

  /// <summary>
  /// Drop-down list form field properties, if the form field is a drop-down list.
  /// </summary>
  [OpenXmlElement(typeof(DXW.DropDownListFormField))]
  public DropDownListFormField? DropDownListFormField
  {
    get => _DropDownListFormField ??= GetElement<DropDownListFormField?, DXW.DropDownListFormField>(GetUpdatableElement());
    set => UpdateField(ref _DropDownListFormField, value, nameof(DropDownListFormField));
  }
  private DropDownListFormField? _DropDownListFormField;

  ///// <summary>
  ///// Text input form field properties, if the form field is a text input.
  ///// </summary>
  //[OpenXmlElement(typeof(DXW.TextInput))]
  //public TextInput? TextInput 
  //{
  //  get => _TextInput ??= GetElement<TextInput?, DXW.TextInput>(_openXmlElement);
  //  set => UpdateField(ref _TextInput, value, nameof(TextInput));
  //}
  //private TextInput? _TextInput;
}