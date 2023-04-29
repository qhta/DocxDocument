namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Checkbox Form Field Properties.
/// </summary>
public class CheckBox: ModelElement
{
  public string? FormFieldSize { get; set; }

  public bool? AutomaticallySizeFormField { get; set; }

  public bool? DefaultCheckBoxFormFieldState { get; set; }

  public bool? Checked { get; set; }
}