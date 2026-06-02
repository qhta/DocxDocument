namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion?view=word-pia"/>
public interface IXMLChildNodeSuggestion : IInteropObject
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.basename?view=word-pia"/>
  public string BaseName { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.xmlschemareference?view=word-pia"/>
  public XMLSchemaReference XMLSchemaReference { get; }


  #region methods

/// <summary>
  /// Inserts a new XML child node at the specified range.
  /// </summary>
  /// <param name="Range">The range where the child node is inserted.</param>
  /// <returns>The created <see cref="XMLNode"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.insert?view=word-pia"/>
  public XMLNode Insert(object Range);

  #endregion methods
}
