namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Document objects that are currently open in Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents?view=word-pia"/>
public partial class Documents : InteropCollection<Document>
{


  #region methods

/// <summary>
  /// Executes the close operation.
  /// </summary>
  /// <param name="saveChanges">Specifies the save changes.</param>
  /// <param name="originalFormat">Specifies the original format.</param>
  /// <param name="routeDocument">Specifies the route document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.close?view=word-pia"/>
  public void Close(object saveChanges, object originalFormat, object routeDocument) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the add old operation.
  /// </summary>
  /// <param name="template">Specifies the template.</param>
  /// <param name="newTemplate">Specifies the new template.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.addold?view=word-pia"/>
  public Document AddOld(object template, object newTemplate) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the open old operation.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <param name="confirmConversions">Specifies the confirm conversions.</param>
  /// <param name="readOnly">Specifies the read only.</param>
  /// <param name="addToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="passwordDocument">Specifies the password document.</param>
  /// <param name="passwordTemplate">Specifies the password template.</param>
  /// <param name="revert">Specifies the revert.</param>
  /// <param name="writePasswordDocument">Specifies the write password document.</param>
  /// <param name="writePasswordTemplate">Specifies the write password template.</param>
  /// <param name="format">Specifies the format.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.openold?view=word-pia"/>
  public Document OpenOld(object fileName, object confirmConversions, object readOnly, object addToRecentFiles, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument, object writePasswordTemplate, object format) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the save operation.
  /// </summary>
  /// <param name="noPrompt">Specifies the no prompt.</param>
  /// <param name="originalFormat">Specifies the original format.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.save?view=word-pia"/>
  public void Save(object noPrompt, object originalFormat) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="template">Specifies the template.</param>
  /// <param name="newTemplate">Specifies the new template.</param>
  /// <param name="documentType">Specifies the document type.</param>
  /// <param name="visible">Specifies the visible.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.add?view=word-pia"/>
  public Document Add(object template, object newTemplate, object documentType, object visible) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the open2000 operation.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <param name="confirmConversions">Specifies the confirm conversions.</param>
  /// <param name="readOnly">Specifies the read only.</param>
  /// <param name="addToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="passwordDocument">Specifies the password document.</param>
  /// <param name="passwordTemplate">Specifies the password template.</param>
  /// <param name="revert">Specifies the revert.</param>
  /// <param name="writePasswordDocument">Specifies the write password document.</param>
  /// <param name="writePasswordTemplate">Specifies the write password template.</param>
  /// <param name="format">Specifies the format.</param>
  /// <param name="encoding">Specifies the encoding.</param>
  /// <param name="visible">Specifies the visible.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.open2000?view=word-pia"/>
  public Document Open2000(object fileName, object confirmConversions, object readOnly, object addToRecentFiles, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument, object writePasswordTemplate, object format, object encoding, object visible) { throw new NotImplementedException(); }

  /// <summary>
  /// Executes the check out operation.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.checkout?view=word-pia"/>
  public void CheckOut(string fileName) { throw new NotImplementedException(); }

  /// <summary>
  /// Determines whether CanCheckOut.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <returns>true if successful; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.cancheckout?view=word-pia"/>
  public bool CanCheckOut(string fileName) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the open2002 operation.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <param name="confirmConversions">Specifies the confirm conversions.</param>
  /// <param name="readOnly">Specifies the read only.</param>
  /// <param name="addToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="passwordDocument">Specifies the password document.</param>
  /// <param name="passwordTemplate">Specifies the password template.</param>
  /// <param name="revert">Specifies the revert.</param>
  /// <param name="writePasswordDocument">Specifies the write password document.</param>
  /// <param name="writePasswordTemplate">Specifies the write password template.</param>
  /// <param name="format">Specifies the format.</param>
  /// <param name="encoding">Specifies the encoding.</param>
  /// <param name="visible">Specifies the visible.</param>
  /// <param name="openAndRepair">Specifies the open and repair.</param>
  /// <param name="documentDirection">Specifies the document direction.</param>
  /// <param name="noEncodingDialog">Specifies the no encoding dialog.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.open2002?view=word-pia"/>
  public Document Open2002(object fileName, object confirmConversions, object readOnly, object addToRecentFiles, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument, object writePasswordTemplate, object format, object encoding, object visible, object openAndRepair, object documentDirection, object noEncodingDialog) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the open operation.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <param name="confirmConversions">Specifies the confirm conversions.</param>
  /// <param name="readOnly">Specifies the read only.</param>
  /// <param name="addToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="passwordDocument">Specifies the password document.</param>
  /// <param name="passwordTemplate">Specifies the password template.</param>
  /// <param name="revert">Specifies the revert.</param>
  /// <param name="writePasswordDocument">Specifies the write password document.</param>
  /// <param name="writePasswordTemplate">Specifies the write password template.</param>
  /// <param name="format">Specifies the format.</param>
  /// <param name="encoding">Specifies the encoding.</param>
  /// <param name="visible">Specifies the visible.</param>
  /// <param name="openAndRepair">Specifies the open and repair.</param>
  /// <param name="documentDirection">Specifies the document direction.</param>
  /// <param name="noEncodingDialog">Specifies the no encoding dialog.</param>
  /// <param name="xMLTransform">Specifies the xmltransform.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.open?view=word-pia"/>
  public Document Open(object fileName, object confirmConversions, object readOnly, object addToRecentFiles, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument, object writePasswordTemplate, object format, object encoding, object visible, object openAndRepair, object documentDirection, object noEncodingDialog, object xMLTransform) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the open no repair dialog operation.
  /// </summary>
  /// <param name="fileName">Specifies the file name.</param>
  /// <param name="confirmConversions">Specifies the confirm conversions.</param>
  /// <param name="readOnly">Specifies the read only.</param>
  /// <param name="addToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="passwordDocument">Specifies the password document.</param>
  /// <param name="passwordTemplate">Specifies the password template.</param>
  /// <param name="revert">Specifies the revert.</param>
  /// <param name="writePasswordDocument">Specifies the write password document.</param>
  /// <param name="writePasswordTemplate">Specifies the write password template.</param>
  /// <param name="format">Specifies the format.</param>
  /// <param name="encoding">Specifies the encoding.</param>
  /// <param name="visible">Specifies the visible.</param>
  /// <param name="openAndRepair">Specifies the open and repair.</param>
  /// <param name="documentDirection">Specifies the document direction.</param>
  /// <param name="noEncodingDialog">Specifies the no encoding dialog.</param>
  /// <param name="xMLTransform">Specifies the xmltransform.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.opennorepairdialog?view=word-pia"/>
  public Document OpenNoRepairDialog(object fileName, object confirmConversions, object readOnly, object addToRecentFiles, object passwordDocument, object passwordTemplate, object revert, object writePasswordDocument, object writePasswordTemplate, object format, object encoding, object visible, object openAndRepair, object documentDirection, object noEncodingDialog, object xMLTransform) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the value produced by the add blog document operation.
  /// </summary>
  /// <param name="providerID">Specifies the provider id.</param>
  /// <param name="postURL">Specifies the post url.</param>
  /// <param name="blogName">Specifies the blog name.</param>
  /// <param name="postID">Specifies the post id.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.addblogdocument?view=word-pia"/>
  public Document AddBlogDocument(string providerID, string postURL, string blogName, string postID) { throw new NotImplementedException(); }

  #endregion methods
}
