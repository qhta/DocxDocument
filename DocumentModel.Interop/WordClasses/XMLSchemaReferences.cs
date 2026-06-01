namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XMLSchemaReference objects that represent the unique namespaces that are attached to a
/// document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences?view=word-pia"/>
public partial class XMLSchemaReferences : InteropCollection<XMLSchemaReference>
{
  /// <summary>
  /// Returns a Application object that represents the Microsoft Word application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.automaticvalidation?view=word-pia"/>
  public bool AutomaticValidation { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.allowsaveasxmlwithoutvalidation?view=word-pia"/>
  public bool AllowSaveAsXMLWithoutValidation { get; set; }

  /// <summary>
  /// Returns a 32-bit integer that indicates the application in which the specified object was created.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.hidevalidationerrors?view=word-pia"/>
  public bool HideValidationErrors { get; set; }

  /// <summary>
  /// True to hide schema violations when Microsoft Word validates the XML in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.ignoremixedcontent?view=word-pia"/>
  public bool IgnoreMixedContent { get; set; }

  /// <summary>
  /// Returns an object that represents the parent object of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareferences.showplaceholdertext?view=word-pia"/>
  public bool ShowPlaceholderText { get; set; }
}
