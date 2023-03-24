namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Checkbox Form Field Properties.
/// </summary>
public class CheckBox: ModelElement
{
  public String? FormFieldSize { get; set; }

  public Boolean? AutomaticallySizeFormField { get; set; }

  public Boolean? DefaultCheckBoxFormFieldState { get; set; }

  public Boolean? Checked { get; set; }
}