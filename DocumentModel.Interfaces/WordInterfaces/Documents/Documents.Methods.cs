namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents?view=word-pia"/>
public partial interface Documents: InteropObject
{
  /// <summary>
  /// Executes the close operation.
  /// </summary>
  /// <param name="SaveChanges">Specifies the save changes.</param>
  /// <param name="OriginalFormat">Specifies the original format.</param>
  /// <param name="RouteDocument">Specifies the route document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.close?view=word-pia"/>
  public void Close(object SaveChanges, object OriginalFormat, object RouteDocument);

  /// <summary>
  /// Returns the value produced by the add old operation.
  /// </summary>
  /// <param name="Template">Specifies the template.</param>
  /// <param name="NewTemplate">Specifies the new template.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.addold?view=word-pia"/>
  public Document AddOld(object Template, object NewTemplate);

  /// <summary>
  /// Returns the value produced by the open old operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <param name="ConfirmConversions">Specifies the confirm conversions.</param>
  /// <param name="ReadOnly">Specifies the read only.</param>
  /// <param name="AddToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="PasswordDocument">Specifies the password document.</param>
  /// <param name="PasswordTemplate">Specifies the password template.</param>
  /// <param name="Revert">Specifies the revert.</param>
  /// <param name="WritePasswordDocument">Specifies the write password document.</param>
  /// <param name="WritePasswordTemplate">Specifies the write password template.</param>
  /// <param name="Format">Specifies the format.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.openold?view=word-pia"/>
  public Document OpenOld(object FileName, object ConfirmConversions, object ReadOnly, object AddToRecentFiles, object PasswordDocument, object PasswordTemplate, object Revert, object WritePasswordDocument, object WritePasswordTemplate, object Format);

  /// <summary>
  /// Executes the save operation.
  /// </summary>
  /// <param name="NoPrompt">Specifies the no prompt.</param>
  /// <param name="OriginalFormat">Specifies the original format.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.save?view=word-pia"/>
  public void Save(object NoPrompt, object OriginalFormat);

  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Template">Specifies the template.</param>
  /// <param name="NewTemplate">Specifies the new template.</param>
  /// <param name="DocumentType">Specifies the document type.</param>
  /// <param name="Visible">Specifies the visible.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.add?view=word-pia"/>
  public Document Add(object Template, object NewTemplate, object DocumentType, object Visible);

  /// <summary>
  /// Returns the value produced by the open2000 operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <param name="ConfirmConversions">Specifies the confirm conversions.</param>
  /// <param name="ReadOnly">Specifies the read only.</param>
  /// <param name="AddToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="PasswordDocument">Specifies the password document.</param>
  /// <param name="PasswordTemplate">Specifies the password template.</param>
  /// <param name="Revert">Specifies the revert.</param>
  /// <param name="WritePasswordDocument">Specifies the write password document.</param>
  /// <param name="WritePasswordTemplate">Specifies the write password template.</param>
  /// <param name="Format">Specifies the format.</param>
  /// <param name="Encoding">Specifies the encoding.</param>
  /// <param name="Visible">Specifies the visible.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.open2000?view=word-pia"/>
  public Document Open2000(object FileName, object ConfirmConversions, object ReadOnly, object AddToRecentFiles, object PasswordDocument, object PasswordTemplate, object Revert, object WritePasswordDocument, object WritePasswordTemplate, object Format, object Encoding, object Visible);

  /// <summary>
  /// Executes the check out operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.checkout?view=word-pia"/>
  public void CheckOut(string FileName);

  /// <summary>
  /// Determines whether CanCheckOut.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <returns>true if successful; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.cancheckout?view=word-pia"/>
  public bool CanCheckOut(string FileName);

  /// <summary>
  /// Returns the value produced by the open2002 operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <param name="ConfirmConversions">Specifies the confirm conversions.</param>
  /// <param name="ReadOnly">Specifies the read only.</param>
  /// <param name="AddToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="PasswordDocument">Specifies the password document.</param>
  /// <param name="PasswordTemplate">Specifies the password template.</param>
  /// <param name="Revert">Specifies the revert.</param>
  /// <param name="WritePasswordDocument">Specifies the write password document.</param>
  /// <param name="WritePasswordTemplate">Specifies the write password template.</param>
  /// <param name="Format">Specifies the format.</param>
  /// <param name="Encoding">Specifies the encoding.</param>
  /// <param name="Visible">Specifies the visible.</param>
  /// <param name="OpenAndRepair">Specifies the open and repair.</param>
  /// <param name="DocumentDirection">Specifies the document direction.</param>
  /// <param name="NoEncodingDialog">Specifies the no encoding dialog.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.open2002?view=word-pia"/>
  public Document Open2002(object FileName, object ConfirmConversions, object ReadOnly, object AddToRecentFiles, object PasswordDocument, object PasswordTemplate, object Revert, object WritePasswordDocument, object WritePasswordTemplate, object Format, object Encoding, object Visible, object OpenAndRepair, object DocumentDirection, object NoEncodingDialog);

  /// <summary>
  /// Returns the value produced by the open operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <param name="ConfirmConversions">Specifies the confirm conversions.</param>
  /// <param name="ReadOnly">Specifies the read only.</param>
  /// <param name="AddToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="PasswordDocument">Specifies the password document.</param>
  /// <param name="PasswordTemplate">Specifies the password template.</param>
  /// <param name="Revert">Specifies the revert.</param>
  /// <param name="WritePasswordDocument">Specifies the write password document.</param>
  /// <param name="WritePasswordTemplate">Specifies the write password template.</param>
  /// <param name="Format">Specifies the format.</param>
  /// <param name="Encoding">Specifies the encoding.</param>
  /// <param name="Visible">Specifies the visible.</param>
  /// <param name="OpenAndRepair">Specifies the open and repair.</param>
  /// <param name="DocumentDirection">Specifies the document direction.</param>
  /// <param name="NoEncodingDialog">Specifies the no encoding dialog.</param>
  /// <param name="XMLTransform">Specifies the xmltransform.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.open?view=word-pia"/>
  public Document Open(object FileName, object ConfirmConversions, object ReadOnly, object AddToRecentFiles, object PasswordDocument, object PasswordTemplate, object Revert, object WritePasswordDocument, object WritePasswordTemplate, object Format, object Encoding, object Visible, object OpenAndRepair, object DocumentDirection, object NoEncodingDialog, object XMLTransform);

  /// <summary>
  /// Returns the value produced by the open no repair dialog operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <param name="ConfirmConversions">Specifies the confirm conversions.</param>
  /// <param name="ReadOnly">Specifies the read only.</param>
  /// <param name="AddToRecentFiles">Specifies the add to recent files.</param>
  /// <param name="PasswordDocument">Specifies the password document.</param>
  /// <param name="PasswordTemplate">Specifies the password template.</param>
  /// <param name="Revert">Specifies the revert.</param>
  /// <param name="WritePasswordDocument">Specifies the write password document.</param>
  /// <param name="WritePasswordTemplate">Specifies the write password template.</param>
  /// <param name="Format">Specifies the format.</param>
  /// <param name="Encoding">Specifies the encoding.</param>
  /// <param name="Visible">Specifies the visible.</param>
  /// <param name="OpenAndRepair">Specifies the open and repair.</param>
  /// <param name="DocumentDirection">Specifies the document direction.</param>
  /// <param name="NoEncodingDialog">Specifies the no encoding dialog.</param>
  /// <param name="XMLTransform">Specifies the xmltransform.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.opennorepairdialog?view=word-pia"/>
  public Document OpenNoRepairDialog(object FileName, object ConfirmConversions, object ReadOnly, object AddToRecentFiles, object PasswordDocument, object PasswordTemplate, object Revert, object WritePasswordDocument, object WritePasswordTemplate, object Format, object Encoding, object Visible, object OpenAndRepair, object DocumentDirection, object NoEncodingDialog, object XMLTransform);

  /// <summary>
  /// Returns the value produced by the add blog document operation.
  /// </summary>
  /// <param name="ProviderID">Specifies the provider id.</param>
  /// <param name="PostURL">Specifies the post url.</param>
  /// <param name="BlogName">Specifies the blog name.</param>
  /// <param name="PostID">Specifies the post id.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents.addblogdocument?view=word-pia"/>
  public Document AddBlogDocument(string ProviderID, string PostURL, string BlogName, string PostID);
}
