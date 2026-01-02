namespace DocumentModel;

/// <summary>
/// Defines a contract for a control that can display a label, either as a static string or determined dynamically by a
/// callback function.
/// </summary>
/// <remarks>Implementations of this interface allow consumers to specify a label directly or provide the name of
/// a callback function to determine the label at runtime. The Label and GetLabel properties are mutually exclusive;
/// only one should be set for a given control. If neither property is set, the control will not display a
/// label.</remarks>
public interface ILabelControl
{
  /// <summary>
  ///   Specifies a string to be used as the label for this control.
  ///
  ///   The Label and GetLabel attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the label of this control.
  ///
  ///   The Label and GetLabel attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed.
  /// </summary>
  public string? GetLabel { get; set; }
}