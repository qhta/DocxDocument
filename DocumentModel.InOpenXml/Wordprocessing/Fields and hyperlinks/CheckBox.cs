namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a checkbox form field in a WordprocessingML document.
/// This class provides properties for form field size, automatic sizing, default state, and checked state, enabling advanced configuration and management of interactive checkbox fields within forms and documents.
/// </summary>
public partial class CheckBox : ModelElement<DXW.CheckBox>
{
    /// <summary>
    /// Size of the checkbox form field, specified as a string value (e.g., in points or percent).
    /// </summary>
    public string? FormFieldSize { get => _FormFieldSize; set => UpdateField(ref _FormFieldSize, value, nameof(FormFieldSize)); }

    private string? _FormFieldSize;
    /// <summary>
    /// Indicates whether the checkbox form field should be automatically sized.
    /// </summary>
    public bool? AutomaticallySizeFormField { get; set; }
    /// <summary>
    /// Default state of the checkbox form field when the form is loaded (checked or unchecked).
    /// </summary>
    public bool? DefaultCheckBoxFormFieldState { get; set; }
    /// <summary>
    /// Indicates whether the checkbox is currently checked.
    /// </summary>
    public bool? Checked { get; set; }
}