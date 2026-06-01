namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Checkbox Form IField Properties.
/// </summary>
public class ICheckBox: ModelElement
{
  public string? FormFieldSize { get; set; }

  public bool? AutomaticallySizeFormField { get; set; }

  public bool? DefaultCheckBoxFormFieldState { get; set; }

  public bool? Checked { get; set; }
}
