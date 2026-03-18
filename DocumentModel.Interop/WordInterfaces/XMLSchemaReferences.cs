namespace DocumentModel.Interop;

/// <summary>
/// A collection of XMLSchemaReference objects that represent the unique namespaces that are attached to a document.
/// </summary>
public partial interface XMLSchemaReferences : InteropObject, InteropCollection<XMLSchemaReference>
{
  /// <summary>
  /// The automatic validation.
  /// </summary>
  public bool AutomaticValidation { get; set; }

  /// <summary>
  /// The allow save as xmlwithout validation.
  /// </summary>
  public bool AllowSaveAsXMLWithoutValidation { get; set; }

  /// <summary>
  /// The hide validation errors.
  /// </summary>
  public bool HideValidationErrors { get; set; }

  /// <summary>
  /// The ignore mixed content.
  /// </summary>
  public bool IgnoreMixedContent { get; set; }

  /// <summary>
  /// The show placeholder text.
  /// </summary>
  public bool ShowPlaceholderText { get; set; }
}
