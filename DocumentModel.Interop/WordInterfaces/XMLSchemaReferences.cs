namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XMLSchemaReference objects that represent the unique namespaces that are attached to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences?view=word-pia"/>
public partial interface XMLSchemaReferences : InteropObject, InteropCollection<XMLSchemaReference>
{
  /// <summary>
  /// The automatic validation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.automaticvalidation?view=word-pia"/>
  public bool AutomaticValidation { get; set; }

  /// <summary>
  /// The allow save as xmlwithout validation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.allowsaveasxmlwithoutvalidation?view=word-pia"/>
  public bool AllowSaveAsXMLWithoutValidation { get; set; }

  /// <summary>
  /// The hide validation errors.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.hidevalidationerrors?view=word-pia"/>
  public bool HideValidationErrors { get; set; }

  /// <summary>
  /// The ignore mixed content.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.ignoremixedcontent?view=word-pia"/>
  public bool IgnoreMixedContent { get; set; }

  /// <summary>
  /// The show placeholder text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.showplaceholdertext?view=word-pia"/>
  public bool ShowPlaceholderText { get; set; }
}
