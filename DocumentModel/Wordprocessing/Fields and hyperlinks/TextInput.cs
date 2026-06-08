namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Box Form IField Properties.
/// </summary>
public class ITextInput: ModelElement
{
  /// <summary>
  ///   Text Box Form IField Type.
  /// </summary>
  public TextBoxFormFieldKind? TextBoxFormFieldType { get; set; }

  /// <summary>
  ///   Default Text Box Form IField String.
  /// </summary>
  public string? DefaultTextBoxFormFieldString { get; set; }

  /// <summary>
  ///   Text Box Form IField Maximum Length.
  /// </summary>
  public Int16? MaxLength { get; set; }

  /// <summary>
  ///   Text Box Form IField Formatting.
  /// </summary>
  public string? Format { get; set; }
}
