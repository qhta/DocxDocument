namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a checkbox form field in a WordprocessingML document.
/// This class provides properties for form field size, automatic sizing, default state, and checked state, enabling advanced configuration and management of interactive checkbox fields within forms and documents.
/// </summary>
[OpenXmlType(typeof(DXW.CheckBox))]
public partial class CheckBox : ModelElement<DXW.CheckBox>
{
 /// <summary>
 /// Size of the checkbox form field, specified as a string value (e.g., in points or percent).
 /// </summary>
 [OpenXmlElement(typeof(DXW.CheckBox))]
 public string? FormFieldSize { get => _FormFieldSize; set => UpdateField(ref _FormFieldSize, value, nameof(FormFieldSize)); }

 private string? _FormFieldSize;
 /// <summary>
 /// Indicates whether the checkbox form field should be automatically sized.
 /// </summary>
 [OpenXmlElement(typeof(DXW.CheckBox))]
 public bool? AutomaticallySizeFormField { get => _AutomaticallySizeFormField; set => UpdateField(ref _AutomaticallySizeFormField, value, nameof(AutomaticallySizeFormField)); }

 private bool? _AutomaticallySizeFormField;
 /// <summary>
 /// Default state of the checkbox form field when the form is loaded (checked or unchecked).
 /// </summary>
 [OpenXmlElement(typeof(DXW.CheckBox))]
 public bool? DefaultCheckBoxFormFieldState { get => _DefaultCheckBoxFormFieldState; set => UpdateField(ref _DefaultCheckBoxFormFieldState, value, nameof(DefaultCheckBoxFormFieldState)); }

 private bool? _DefaultCheckBoxFormFieldState;
 /// <summary>
 /// Indicates whether the checkbox is currently checked.
 /// </summary>
 [OpenXmlElement(typeof(DXW.CheckBox))]
 public bool? Checked { get => _Checked; set => UpdateField(ref _Checked, value, nameof(Checked)); }

 private bool? _Checked;
}