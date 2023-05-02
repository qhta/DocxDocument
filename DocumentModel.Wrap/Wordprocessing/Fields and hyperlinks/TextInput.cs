namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Box Form Field Properties.
/// </summary>
public class TextInput: ModelElement
{
  /// <summary>
  ///   Text Box Form Field Type.
  /// </summary>
  public TextBoxFormFieldKind? TextBoxFormFieldType { get; set; }

  /// <summary>
  ///   Default Text Box Form Field String.
  /// </summary>
  public string? DefaultTextBoxFormFieldString { get; set; }

  /// <summary>
  ///   Text Box Form Field Maximum Length.
  /// </summary>
  public Int16? MaxLength { get; set; }

  /// <summary>
  ///   Text Box Form Field Formatting.
  /// </summary>
  public string? Format { get; set; }
}