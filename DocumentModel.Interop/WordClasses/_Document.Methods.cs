namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document?view=word-pia"/>
public partial class _Document: InteropObject
{
  /// <summary>
  /// Returns the writing style for a specified language in the specified document.
  /// </summary>
  /// <param name="languageID">The language ID for which to return the writing style.</param>
  /// <returns>The writing style for the specified language.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activewritingstyle?view=word-pia"/>
  public string ActiveWritingStyle(object languageID) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the writing style for a specified language in the specified document.
  /// </summary>
  /// <param name="languageID">The language ID for which to set the writing style.</param>
  /// <param name="style">The writing style to set for the specified language.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activewritingstyle?view=word-pia"/>
  public void ActiveWritingStyle(object languageID, string style) { throw new NotImplementedException(); }

  /// <summary>
  /// Determines whether the specified compatibility option is enabled.
  /// </summary>
  /// <param name="type">A value that specifies the compatibility option to check.</param>
  /// <returns>true if the specified compatibility option is enabled; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compatibility?view=word-pia"/>
  public bool Compatibility(Compatibility type) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the active writing style compatibility option for the specified type.
  /// </summary>
  /// <param name="type">The compatibility option to set, indicating the type of writing style to apply.</param>
  /// <param name="compatibility">A value indicating whether the specified compatibility option is enabled. Set to <see langword="true"/> to enable
  /// the option; otherwise, <see langword="false"/>.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setcompatibility?view=word-pia"/>
  public void SetCompatibility(Compatibility type, bool compatibility) { throw new NotImplementedException(); }

  /// <summary>
  /// Accepts all tracked changes in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.acceptallrevisions?view=word-pia"/>
  public void AcceptAllRevisions() { throw new NotImplementedException(); }

  /// <summary>
  /// Accepts all revisions in the specified document that are displayed on the screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.acceptallrevisionsshown?view=word-pia"/>
  public void AcceptAllRevisionsShown() { throw new NotImplementedException(); }

  /// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activate?view=word-pia"/>
  public void Activate() { throw new NotImplementedException(); }

  /// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.adddocumentworkspaceheader?view=word-pia"/>
  public void AddDocumentWorkspaceHeader(bool RichFormat, string Url, string Title, string Description, string ID) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.addmeetingworkspaceheader?view=word-pia"/>
  public void AddMeetingWorkspaceHeader(bool SkipIfAbsent, string Url, string Title, string Description, string ID) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates a shortcut to the document or hyperlink and adds it to the Favorites folder.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.addtofavorites?view=word-pia"/>
  public void AddToFavorites() { throw new NotImplementedException(); }

  /// <summary>
  /// Applies a document theme to a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applydocumenttheme?view=word-pia"/>
  public void ApplyDocumentTheme(string FileName) { throw new NotImplementedException(); }

  /// <summary>
  /// Changes the set of quick styles listed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applyquickstyleset?view=word-pia"/>
  public void ApplyQuickStyleSet(string Name) { throw new NotImplementedException(); }

  /// <summary>
  /// Applies the specified Quick Style set to the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applyquickstyleset2?view=word-pia"/>
  public void ApplyQuickStyleSet2(object Style) { throw new NotImplementedException(); }

  /// <summary>
  /// Applies a theme to an open document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applytheme?view=word-pia"/>
  public void ApplyTheme(string Name) { throw new NotImplementedException(); }

  /// <summary>
  /// Automatically formats a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autoformat?view=word-pia"/>
  public void AutoFormat() { throw new NotImplementedException(); }

  /// <summary>
  /// Creates an automatic summary of the specified document, and returns a Range object.
  /// </summary>
  /// <param name="length">The length of the summary as a percentage of the total document length
  /// (the larger the number, the more detail that's included in the summary).</param>
  /// <param name="mode">Specifies the way the summary is displayed. Can be one of the SummaryMode constants.</param>
  /// <param name="updateProperties">True to update the Keyword and Comments boxes in the Properties dialog box
  /// to reflect the content of the summary for the specified document.</param>
  /// <returns>A Range object representing the summary.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autosummarize?view=word-pia"/>
  public Range AutoSummarize(SummaryLength length, SummaryMode mode, object updateProperties) { throw new NotImplementedException(); }

  /// <summary>
  /// Determines if Microsoft Word can check in a specified document to a server.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.cancheckin?view=word-pia"/>
  public bool CanCheckin() { throw new NotImplementedException(); }

  /// <summary>
  /// Searches all text in a Japanese language document and displays instances where character usage is inconsistent
  /// for the same words.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkconsistency?view=word-pia"/>
  public void CheckConsistency() { throw new NotImplementedException(); }

  /// <summary>
  /// Begins a spelling and grammar check for the specified document or range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkgrammar?view=word-pia"/>
  public void CheckGrammar() { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a document from a local computer to a server, and sets the local document to read-only so that it cannot be edited locally.
  /// </summary>
  /// <param name="SaveChanges">True saves the document to the server location. The default is True</param>
  /// <param name="Comments">Comments for the revision of the document being checked in (only applies if SaveChanges equals True).</param>
  /// <param name="MakePublic">True allows the user to publish on the document after being checked in.
  /// This submits the document for the approval process, which can eventually result in a version of the document
  /// being published to users with read-only rights to the document (only applies if SaveChanges equals True).</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkin?view=word-pia"/>
  public void CheckIn(bool SaveChanges, object Comments, bool MakePublic) { throw new NotImplementedException(); }

  /// <summary>
  /// Puts a document on a server from a local computer, and sets the local document to read-only so that it cannot be edited locally.
  /// </summary>
  /// <param name="SaveChanges">True saves the document to the server location. The default is True</param>
  /// <param name="Comments">Comments for the revision of the document being checked in (only applies if SaveChanges equals True).</param>
  /// <param name="MakePublic">True allows the user to publish on the document after being checked in.
  /// This submits the document for the approval process, which can eventually result in a version of the document
  /// being published to users with read-only rights to the document (only applies if SaveChanges equals True).</param>
  /// <param name="VersionType">The version type to assign to the document being checked in. Can be one of the CheckInVersionType constants (only applies if SaveChanges equals True).</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkinwithversion?view=word-pia"/>
  public void CheckInWithVersion(bool SaveChanges, object Comments, bool MakePublic, CheckInVersionType VersionType) { throw new NotImplementedException(); }

  /// <summary>
  /// Accesses the Microsoft Office Web site for available smart tag recognizer and action files.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checknewsmarttags?view=word-pia"/>
  public void CheckNewSmartTags() { throw new NotImplementedException(); }

  /// <summary>
  /// Begins a spelling check for the specified document or range.
  /// </summary>
  /// <param name="CustomDictionary">Either an expression that returns a Dictionary object or the file name of the custom dictionary.</param>
  /// <param name="IgnoreUppercase">True if capitalization is ignored. If this argument is omitted, the current value of the IgnoreUppercase property is used.</param>
  /// <param name="AlwaysSuggest">True for Microsoft Word to always suggest alternative spellings. If this argument is omitted, the current value of the SuggestSpellingCorrections property is used.</param>
  /// <param name="CustomDictionary2">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary3">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary4">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary5">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary6">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary7">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary8">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary9">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary10">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkspelling?view=word-pia"/>
  public void CheckSpelling
  (object CustomDictionary, bool IgnoreUppercase, bool AlwaysSuggest, object CustomDictionary2,
    object CustomDictionary3, object CustomDictionary4, object CustomDictionary5, object CustomDictionary6,
    object CustomDictionary7, object CustomDictionary8, object CustomDictionary9, object CustomDictionary10)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Closes the specified document or documents.
  /// </summary>
  /// <param name="SaveChanges">Specifies whether to save changes to the document. Can be one of the SaveOptions constants.</param>
  /// <param name="OriginalFormat">Specifies the format in which to save the document. Can be one of the OriginalFormat constants.</param>
  /// <param name="RouteDocument">Specifies whether to route the document. Can be True or False.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.close?view=word-pia"/>
  public void Close(SaveOptions SaveChanges, OriginalFormat OriginalFormat, bool RouteDocument) { throw new NotImplementedException(); }

  /// <summary>
  /// Switches the specified document from print preview to the previous view. If the specified document isn't in
  /// print preview, an error occurs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.closeprintpreview?view=word-pia"/>
  public void ClosePrintPreview() { throw new NotImplementedException(); }

  /// <summary>
  /// Displays revision marks that indicate where the specified document differs from another document.
  /// </summary>
  /// <param name="Name">The name of the document to compare with the specified document.</param>
  /// <param name="AuthorName">The name of the author to use for the comparison.</param>
  /// <param name="CompareTarget">Specifies the target for the comparison. Can be one of the CompareTarget constants.</param>
  /// <param name="DetectFormatChanges">Specifies whether to detect format changes. Can be True or False.</param>
  /// <param name="IgnoreAllComparisonWarnings">Specifies whether to ignore all comparison warnings. Can be True or False.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the recent files list. Can be True or False.</param>
  /// <param name="RemovePersonalInformation">Specifies whether to remove personal information. Can be True or False.</param>
  /// <param name="RemoveDateAndTime">Specifies whether to remove date and time information. Can be True or False.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compare?view=word-pia"/>
  public void Compare
  (string Name, string AuthorName, CompareTarget CompareTarget, bool DetectFormatChanges, bool IgnoreAllComparisonWarnings,
    bool AddToRecentFiles, bool RemovePersonalInformation, bool RemoveDateAndTime) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Name">The name of the document to compare with the specified document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compare2000?view=word-pia"/>
  public void Compare2000(string Name) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Name">The name of the document to compare with the specified document.</param>
  /// <param name="AuthorName">The name of the author to use for the comparison.</param>
  /// <param name="CompareTarget">Specifies the target for the comparison. Can be one of the CompareTarget constants.</param>
  /// <param name="DetectFormatChanges">Specifies whether to detect format changes. Can be True or False.</param>
  /// <param name="IgnoreAllComparisonWarnings">Specifies whether to ignore all comparison warnings. Can be True or False.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the recent files list. Can be True or False.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compare2002?view=word-pia"/>
  public void Compare2002
  (string Name, string AuthorName, CompareTarget CompareTarget, bool DetectFormatChanges, bool IgnoreAllComparisonWarnings,
    bool AddToRecentFiles) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a statistic based on the contents of the specified document.
  /// </summary>
  /// <param name="Statistic">The statistic to return. Can be one of the Statistic constants.</param>
  /// <param name="IncludeFootnotesAndEndnotes">Specifies whether to include footnotes and endnotes. Can be True or False.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.computestatistics?view=word-pia"/>
  public int ComputeStatistics(Statistic Statistic, bool IncludeFootnotesAndEndnotes) { throw new NotImplementedException(); }

  /// <summary>
  /// Converts file to the newest file format and enables all new features.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convert?view=word-pia"/>
  public void Convert() { throw new NotImplementedException(); }

  /// <summary>
  /// Converts hyphens created by automatic hyphenation to manual hyphens.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convertautohyphens?view=word-pia"/>
  public void ConvertAutoHyphens() { throw new NotImplementedException(); }

  /// <summary>
  /// Changes the list numbers and LISTNUM fields in the specified object to text.
  /// </summary>
  /// <param name="NumberType">The type of numbers to convert. Can be one of the NumberType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convertnumberstotext?view=word-pia"/>
  public void ConvertNumbersToText(NumberType NumberType) { throw new NotImplementedException(); }

  /// <summary>
  /// Reconverts a Vietnamese document to Unicode using a code page other than the default.
  /// </summary>
  /// <param name="CodePageOrigin">The code page to use for the conversion.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convertvietdoc?view=word-pia"/>
  public void ConvertVietDoc(int CodePageOrigin) { throw new NotImplementedException(); }

  /// <summary>
  /// Copies styles from the specified template to a document.
  /// </summary>
  /// <param name="Template">The name of the template from which to copy styles.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.copystylesfromtemplate?view=word-pia"/>
  public void CopyStylesFromTemplate(string Template) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the number of bulleted or numbered items and LISTNUM fields in the specified object.
  /// </summary>
  /// <param name="NumberType">The type of numbers to count. Can be one of the NumberType constants.</param>
  /// <param name="Level">The level of the numbers to count. Can be one of the WdListLevel constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.countnumbereditems?view=word-pia"/>
  public int CountNumberedItems(NumberType NumberType, int Level) { throw new NotImplementedException(); }

  /// <summary>
  /// Creates and returns a LetterContent object based on the specified letter elements.
  /// </summary>
  /// <param name="DateFormat">The format of the date.</param>
  /// <param name="IncludeHeaderFooter">Specifies whether to include the header and footer. Can be True or False.</param>
  /// <param name="PageDesign">The design of the page.</param>
  /// <param name="LetterStyle">The style of the letter.</param>
  /// <param name="Letterhead">Specifies whether to include the letterhead. Can be True or False.</param>
  /// <param name="LetterheadLocation">The location of the letterhead. Can be one of the LetterheadLocation constants.</param>
  /// <param name="LetterheadSize">The size of the letterhead.</param>
  /// <param name="RecipientName">The name of the recipient.</param>
  /// <param name="RecipientAddress">The address of the recipient.</param>
  /// <param name="Salutation">The salutation to use in the letter.</param>
  /// <param name="SalutationType">The type of salutation to use in the letter. Can be one of the SalutationType constants.</param>
  /// <param name="RecipientReference">The reference for the recipient.</param>
  /// <param name="MailingInstructions">The mailing instructions for the letter.</param>
  /// <param name="AttentionLine">The attention line for the letter.</param>
  /// <param name="Subject">The subject of the letter.</param>
  /// <param name="CCList">The list of recipients to receive a copy of the letter.</param>
  /// <param name="ReturnAddress">The return address for the letter.</param>
  /// <param name="SenderName">The name of the sender.</param>
  /// <param name="Closing">The closing to use in the letter.</param>
  /// <param name="SenderCompany">The company of the sender.</param>
  /// <param name="SenderJobTitle">The job title of the sender.</param>
  /// <param name="SenderInitials">The initials of the sender.</param>
  /// <param name="EnclosureNumber">The number of enclosures to include with the letter.</param>
  /// <param name="InfoBlock">The information block to include in the letter.</param>
  /// <param name="RecipientCode">The code for the recipient.</param>
  /// <param name="RecipientGender">The gender of the recipient.</param>
  /// <param name="ReturnAddressShortForm">The short form of the return address.</param>
  /// <param name="SenderCity">The city of the sender.</param>
  /// <param name="SenderCode">The code of the sender.</param>
  /// <param name="SenderGender">The gender of the sender.</param>
  /// <param name="SenderReference">The reference for the sender.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.createlettercontent?view=word-pia"/>
  public LetterContent CreateLetterContent
  (string DateFormat, bool IncludeHeaderFooter, string PageDesign, LetterStyle LetterStyle, bool Letterhead,
    LetterheadLocation LetterheadLocation, float LetterheadSize, string RecipientName, string RecipientAddress,
    string Salutation, SalutationType SalutationType, string RecipientReference, string MailingInstructions,
    string AttentionLine, string Subject, string CCList, string ReturnAddress, string SenderName, string Closing,
    string SenderCompany, string SenderJobTitle, string SenderInitials, int EnclosureNumber, object InfoBlock,
    object RecipientCode, object RecipientGender, object ReturnAddressShortForm, object SenderCity, object SenderCode,
    object SenderGender, object SenderReference)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Displays the Data Form dialog box, in which you can add, delete, or modify data records.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dataform?view=word-pia"/>
  public void DataForm() { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes all comments from the Comments collection in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deleteallcomments?view=word-pia"/>
  public void DeleteAllComments() { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes all revisions in a specified document that are displayed on the screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deleteallcommentsshown?view=word-pia"/>
  public void DeleteAllCommentsShown() { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes permissions in all ranges for which the specified user or group of users has permission to modify.
  /// </summary>
  /// <param name="EditorID">The user or group of users for which to delete permissions. Can be a user name, group name, or a combination of user and group names.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deletealleditableranges?view=word-pia"/>
  public void DeleteAllEditableRanges(object EditorID) { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes all handwritten ink annotations in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deleteallinkannotations?view=word-pia"/>
  public void DeleteAllInkAnnotations() { throw new NotImplementedException(); }

  /// <summary>
  /// Analyzes the specified text to determine the language that it is written in.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.detectlanguage?view=word-pia"/>
  public void DetectLanguage() { throw new NotImplementedException(); }

  /// <summary>
  /// Downgrades a document to the Word 97-2003 document format so that it can be edited in a previous version of
  /// Microsoft Office Word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.downgradedocument?view=word-pia"/>
  public void DowngradeDocument() { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy1?view=word-pia"/>
  public void Dummy1() { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy2?view=word-pia"/>
  public void Dummy2() { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy3?view=word-pia"/>
  public void Dummy3() { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy4?view=word-pia"/>
  public void Dummy4() { throw new NotImplementedException(); }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <param name="Type">The type of edition.</param>
  /// <param name="Option">The edition option.</param>
  /// <param name="Name">The name of the edition.</param>
  /// <param name="Format">The format of the edition.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.editionoptions?view=word-pia"/>
  public void EditionOptions(EditionType Type, EditionOption Option, string Name, object Format) { throw new NotImplementedException(); }

  /// <summary>
  /// Terminates a review of a file that has been sent for review using the SendForReview(Object, Object, Object,
  /// Object) method or that has been automatically placed in a review cycle by sending a document to another user
  /// in an e-mail message.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.endreview?view=word-pia"/>
  public void EndReview() { throw new NotImplementedException(); }

  /// <summary>
  /// Saves a document as PDF or XPS format.
  /// </summary>
  /// <param name="OutputFileName">The name of the output file.</param>
  /// <param name="ExportFormat">The format to export the document to.</param>
  /// <param name="OpenAfterExport">Whether to open the document after export.</param>
  /// <param name="OptimizeFor">The optimization setting for the export.</param>
  /// <param name="Range">The range of pages to export.</param>
  /// <param name="From">The starting page number for the export.</param>
  /// <param name="To">The ending page number for the export.</param>
  /// <param name="Item">The item to export.</param>
  /// <param name="IncludeDocProps">Whether to include document properties.</param>
  /// <param name="KeepIRM">Whether to keep IRM settings.</param>
  /// <param name="CreateBookmarks">The bookmark creation setting.</param>
  /// <param name="DocStructureTags">Whether to include document structure tags.</param>
  /// <param name="BitmapMissingFonts">Whether to bitmap missing fonts.</param>
  /// <param name="UseISO19005_1">Whether to use ISO 19005-1 standard.</param>
  /// <param name="FixedFormatExtClassPtr">Specifies a pointer to an add-in that allows calls to an alternate
  /// implementation of code.The alternate implementation of code interprets the EMF and EMF+ page descriptions
  /// that are generated by the applications to make their own PDF or XPS. For more information,
  /// see "Extending the Office (2007) Fixed-Format Export Feature" on MSDN.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.exportasfixedformat?view=word-pia"/>
  public void ExportAsFixedFormat
  (string OutputFileName, ExportFormat ExportFormat, bool OpenAfterExport, ExportOptimizeFor OptimizeFor,
    ExportRange Range, int From, int To, ExportItem Item, bool IncludeDocProps, bool KeepIRM,
    ExportCreateBookmarks CreateBookmarks, bool DocStructureTags, bool BitmapMissingFonts, bool UseISO19005_1,
    object FixedFormatExtClassPtr) { throw new NotImplementedException(); }

  /// <summary>
  /// Decreases the font size of text just enough so that the document will fit on one fewer pages.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fittopages?view=word-pia"/>
  public void FitToPages() { throw new NotImplementedException(); }

  /// <summary>
  /// Displays a cached document if it's already been downloaded. Otherwise, this method resolves the hyperlink, downloads the target document, and displays the document in the appropriate application.
  /// </summary>
  /// <param name="Address">The URL of the target document.</param>
  /// <param name="SubAddress">The location within the target document.</param>
  /// <param name="NewWindow">Whether to open the target document in a new window.</param>
  /// <param name="AddHistory">Whether to add the target document to the history list.</param>
  /// <param name="ExtraInfo">Additional information for the hyperlink.</param>
  /// <param name="Method">The method to use for the hyperlink.</param>
  /// <param name="HeaderInfo">Header information for the hyperlink.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.followhyperlink?view=word-pia"/>
  public void FollowHyperlink
  (string Address, string SubAddress, bool NewWindow, bool AddHistory, object ExtraInfo, object Method,
    object HeaderInfo) { throw new NotImplementedException(); }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.forwardmailer?view=word-pia"/>
  public void ForwardMailer() { throw new NotImplementedException(); }

  /// <summary>
  /// In Web view, fixes the layout of the document as it currently appears so that line breaks remain fixed and ink
  /// annotations do not move when you resize the window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.freezelayout?view=word-pia"/>
  public void FreezeLayout() { throw new NotImplementedException(); }

  /// <summary>
  /// Returns an array of items that can be cross-referenced based on the specified cross-reference type.
  /// </summary>
  /// <param name="ReferenceType">The type of items to return. Can be one of the ReferenceType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getcrossreferenceitems?view=word-pia"/>
  public object GetCrossReferenceItems(ReferenceType ReferenceType) { throw new NotImplementedException(); }

  /// <summary>
  /// Retrieves letter elements from the specified document and returns a LetterContent object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getlettercontent?view=word-pia"/>
  public LetterContent GetLetterContent() { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the workflow tasks assigned to a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getworkflowtasks?view=word-pia"/>
  public Core.WorkflowTasks GetWorkflowTasks() { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the workflow templates attached to a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getworkflowtemplates?view=word-pia"/>
  public Core.WorkflowTemplates GetWorkflowTemplates() { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a Range object that represents the start position of the specified item.
  /// </summary>
  /// <param name="What">The item to return. Can be one of the GoToItem constants.</param>
  /// <param name="Which">Specifies which instance of the item to return. Can be one of the GoToDirection constants.</param>
  /// <param name="Count">Specifies the number of items to return.</param>
  /// <param name="Name">Specifies the name of the item to return.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.goto?view=word-pia"/>
  public Range GoTo(GoToItem What, GoToDirection Which, int Count, string Name) { throw new NotImplementedException(); }

  /// <summary>
  /// Locks the file on the server preventing anyone else from editing it.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.lockserverfile?view=word-pia"/>
  public void LockServerFile() { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the compatibility options on the Compatibility tab in the Options dialog box (Tools menu) as the default
  /// settings for new documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.makecompatibilitydefault?view=word-pia"/>
  public void MakeCompatibilityDefault() { throw new NotImplementedException(); }

  /// <summary>
  /// Initiates manual hyphenation of a document, one line at a time. The user is prompted to accept or decline
  /// suggested hyphenations.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.manualhyphenation?view=word-pia"/>
  public void ManualHyphenation() { throw new NotImplementedException(); }

  /// <summary>
  /// Merges the changes marked with revision marks from one document to another.
  /// </summary>
  /// <param name="FileName">The name of the document to merge with the specified document.</param>
  /// <param name="MergeTarget">Specifies the target for the merge. Can be one of the MergeTarget constants.</param>
  /// <param name="DetectFormatChanges">Specifies whether to detect format changes. Can be one of the MergeFormatFrom constants.</param>
  /// <param name="UseFormattingFrom">Specifies which document's formatting to use. Can be one of the WdMergeFormattingFrom constants.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the merged document to the recent files list.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.merge?view=word-pia"/>
  public void Merge
  (string FileName, MergeTarget MergeTarget, MergeFormatFrom DetectFormatChanges, object UseFormattingFrom,
    bool AddToRecentFiles) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.merge2000?view=word-pia"/>
  public void Merge2000(string FileName) { throw new NotImplementedException(); }

  /// <summary>
  /// Posts the specified document to a public folder in Microsoft Exchange. This method displays the Send to
  /// Exchange Folder dialog box so that a folder can be selected.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.post?view=word-pia"/>
  public void Post() { throw new NotImplementedException(); }

  /// <summary>
  /// Opens PowerPoint with the specified Word document loaded.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.presentit?view=word-pia"/>
  public void PresentIt() { throw new NotImplementedException(); }

  /// <summary>
  /// Prints all or part of the specified document.
  /// </summary>
  /// <param name="Background">Whether to print in the background. Can be True or False.</param>
  /// <param name="Append">Whether to append the document to the printer queue. Can be True or False.</param>
  /// <param name="Range">The range of the document to print. Can be one of the PrintOutRange constants.</param>
  /// <param name="OutputFileName">The name of the file to print to when printing to a file.</param>
  /// <param name="From">The starting page number to print.</param>
  /// <param name="To">The ending page number to print.</param>
  /// <param name="Item">Specifies the item to print. Can be one of the PrintOutItem constants.</param>
  /// <param name="Copies">The number of copies to print.</param>
  /// <param name="Pages">The pages to print. Can be a string specifying page ranges.</param>
  /// <param name="PageType">Specifies the type of pages to print. Can be one of the PrintOutPages constants.</param>
  /// <param name="PrintToFile">Whether to print to a file. Can be True or False.</param>
  /// <param name="Collate">Whether to collate multiple copies. Can be True or False.</param>
  /// <param name="ActivePrinterMacGX">The name of the printer to use when printing from a Macintosh running Mac OS X.</param>
  /// <param name="ManualDuplexPrint">Whether to print manually on both sides of the paper. Can be True or False.</param>
  /// <param name="PrintZoomColumn">The number of columns to use when printing in zoom mode.</param>
  /// <param name="PrintZoomRow">The number of rows to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperWidth">The width of the paper to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperHeight">The height of the paper to use when printing in zoom mode.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printout?view=word-pia"/>
  public void PrintOut
  (bool Background, bool Append, PrintOutRange Range, string OutputFileName, int From, int To, PrintOutItem Item,
    int Copies, string Pages, PrintOutPages PageType, bool PrintToFile, bool Collate, string ActivePrinterMacGX,
    bool ManualDuplexPrint, int PrintZoomColumn, int PrintZoomRow, int PrintZoomPaperWidth,
    int PrintZoomPaperHeight) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Background">Whether to print in the background. Can be True or False.</param>
  /// <param name="Append">Whether to append the document to the printer queue. Can be True or False.</param>
  /// <param name="Range">The range of the document to print. Can be one of the PrintOutRange constants.</param>
  /// <param name="OutputFileName">The name of the file to print to when printing to a file.</param>
  /// <param name="From">The starting page number to print.</param>
  /// <param name="To">The ending page number to print.</param>
  /// <param name="Item">Specifies the item to print. Can be one of the PrintOutItem constants.</param>
  /// <param name="Copies">The number of copies to print.</param>
  /// <param name="Pages">The pages to print. Can be a string specifying page ranges.</param>
  /// <param name="PageType">Specifies the type of pages to print. Can be one of the PrintOutPages constants.</param>
  /// <param name="PrintToFile">Whether to print to a file. Can be True or False.</param>
  /// <param name="Collate">Whether to collate multiple copies. Can be True or False.</param>
  /// <param name="ActivePrinterMacGX">The name of the printer to use when printing from a Macintosh running Mac OS X.</param>
  /// <param name="ManualDuplexPrint">Whether to print manually on both sides of the paper. Can be True or False.</param>
  /// <param name="PrintZoomColumn">The number of columns to use when printing in zoom mode.</param>
  /// <param name="PrintZoomRow">The number of rows to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperWidth">The width of the paper to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperHeight">The height of the paper to use when printing in zoom mode.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printout2000?view=word-pia"/>
  public void PrintOut2000
  (bool Background, bool Append, PrintOutRange Range, string OutputFileName, int From, int To, PrintOutItem Item,
    int Copies, string Pages, PrintOutPages PageType, bool PrintToFile, bool Collate, string ActivePrinterMacGX,
    bool ManualDuplexPrint, int PrintZoomColumn, int PrintZoomRow, int PrintZoomPaperWidth,
    int PrintZoomPaperHeight) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Background">Whether to print in the background. Can be True or False.</param>
  /// <param name="Append">Whether to append the document to the printer queue. Can be True or False.</param>
  /// <param name="Range">The range of the document to print. Can be one of the PrintOutRange constants.</param>
  /// <param name="OutputFileName">The name of the file to print to when printing to a file.</param>
  /// <param name="From">The starting page number to print.</param>
  /// <param name="To">The ending page number to print.</param>
  /// <param name="Item">Specifies the item to print. Can be one of the PrintOutItem constants.</param>
  /// <param name="Copies">The number of copies to print.</param>
  /// <param name="Pages">The pages to print. Can be a string specifying page ranges.</param>
  /// <param name="PageType">Specifies the type of pages to print. Can be one of the PrintOutPages constants.</param>
  /// <param name="PrintToFile">Whether to print to a file. Can be True or False.</param>
  /// <param name="Collate">Whether to collate multiple copies. Can be True or False.</param>
  /// <param name="ActivePrinterMacGX">The name of the printer to use when printing from a Macintosh running Mac OS X.</param>
  /// <param name="ManualDuplexPrint">Whether to print manually on both sides of the paper. Can be True or False.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printoutold?view=word-pia"/>
  public void PrintOutOld
  (object Background, object Append, object Range, object OutputFileName, object From, object To, object Item,
    object Copies, object Pages, object PageType, object PrintToFile, object Collate, object ActivePrinterMacGX,
    object ManualDuplexPrint) { throw new NotImplementedException(); }

  /// <summary>
  /// Switches the view to print preview.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printpreview?view=word-pia"/>
  public void PrintPreview() { throw new NotImplementedException(); }

  /// <summary>
  /// Helps to protect the specified document from changes. When a document is protected, users can make only limited changes, such as adding annotations, making revisions, or completing a form.
  /// </summary>
  /// <param name="Type">The type of protection to apply. Can be one of the ProtectionType constants.</param>
  /// <param name="NoReset">Whether to reset the protection settings. Can be True or False.</param>
  /// <param name="Password">The password to use for protection.</param>
  /// <param name="UseIRM">Whether to use Information Rights Management (IRM) for protection. Can be True or False.</param>
  /// <param name="EnforceStyleLock">Whether to enforce style lock. Can be True or False.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.protect?view=word-pia"/>
  public void Protect(ProtectionType Type, bool NoReset, string Password, bool UseIRM, bool EnforceStyleLock) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Type">The type of protection to apply. Can be one of the ProtectionType constants.</param>
  /// <param name="NoReset">Whether to reset the protection settings. Can be True or False.</param>
  /// <param name="Password">The password to use for protection.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.protect2002?view=word-pia"/>
  public void Protect2002(ProtectionType Type, bool NoReset, string Password) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a Range object by using the specified starting and ending character positions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.range?view=word-pia"/>
  public Range Range(object Start, object End) { throw new NotImplementedException(); }

  /// <summary>
  /// Removes smart tags recognized by the grammar checker and rechecks the document content against all smart tag
  /// recognizers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.rechecksmarttags?view=word-pia"/>
  public void RecheckSmartTags() { throw new NotImplementedException(); }

  /// <summary>
  /// Redoes the last action that was undone (reverses the Undo(Object) method). Returns True if the actions were redone successfully.
  /// </summary>
  /// <param name="Times">The number of times to redo the last action. If this argument is omitted, the default value is 1.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.redo?view=word-pia"/>
  public bool Redo(int Times) { throw new NotImplementedException(); }

  /// <summary>
  /// Rejects all tracked changes in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.rejectallrevisions?view=word-pia"/>
  public void RejectAllRevisions() { throw new NotImplementedException(); }

  /// <summary>
  /// Rejects all revisions in a document that are displayed on the screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.rejectallrevisionsshown?view=word-pia"/>
  public void RejectAllRevisionsShown() { throw new NotImplementedException(); }

  /// <summary>
  /// Reloads a cached document by resolving the hyperlink to the document and downloading it.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reload?view=word-pia"/>
  public void Reload() { throw new NotImplementedException(); }

  /// <summary>
  /// Reloads a document based on an HTML document, using the specified document encoding.
  /// </summary>
  /// <param name="Encoding">The encoding to use for the HTML document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reloadas?view=word-pia"/>
  public void ReloadAs(Core.Encoding Encoding) { throw new NotImplementedException(); }

  /// <summary>
  /// Removes sensitive information, properties, comments, and other metadata from a document.
  /// </summary>
  /// <param name="RemoveDocInfoType">The type of information to remove. Can be one of the RemoveDocInfoType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removedocumentinformation?view=word-pia"/>
  public void RemoveDocumentInformation(RemoveDocInfoType RemoveDocInfoType) { throw new NotImplementedException(); }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="ID">The ID of the document workspace header to remove.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removedocumentworkspaceheader?view=word-pia"/>
  public void RemoveDocumentWorkspaceHeader(string ID) { throw new NotImplementedException(); }

  /// <summary>
  /// Purges a document of locked styles when formatting restrictions have been applied in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removelockedstyles?view=word-pia"/>
  public void RemoveLockedStyles() { throw new NotImplementedException(); }

  /// <summary>
  /// Removes numbers or bullets from the specified object.
  /// </summary>
  /// <param name="NumberType">The type of numbering to remove. Can be one of the NumberType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removenumbers?view=word-pia"/>
  public void RemoveNumbers(NumberType NumberType) { throw new NotImplementedException(); }

  /// <summary>
  /// Removes all smart tag information from a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removesmarttags?view=word-pia"/>
  public void RemoveSmartTags() { throw new NotImplementedException(); }

  /// <summary>
  /// Removes the active theme from the current document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removetheme?view=word-pia"/>
  public void RemoveTheme() { throw new NotImplementedException(); }

  /// <summary>
  /// Repaginates the entire document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.repaginate?view=word-pia"/>
  public void Repaginate() { throw new NotImplementedException(); }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reply?view=word-pia"/>
  public void Reply() { throw new NotImplementedException(); }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.replyall?view=word-pia"/>
  public void ReplyAll() { throw new NotImplementedException(); }

  /// <summary>
  /// Sends an e-mail message to the author of a document that has been sent out for review, notifying them that a reviewer has completed review of the document.
  /// </summary>
  /// <param name="ShowMessage">Specifies whether to show a message when replying with changes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.replywithchanges?view=word-pia"/>
  public void ReplyWithChanges(bool ShowMessage) { throw new NotImplementedException(); }

  /// <summary>
  /// Clears all form fields in a document, preparing the form to be filled in again.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.resetformfields?view=word-pia"/>
  public void ResetFormFields() { throw new NotImplementedException(); }

  /// <summary>
  /// Returns the active document to the last saved reading position, and returns an integer that represents that
  /// position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.returntolastreadposition?view=word-pia"/>
  public int ReturnToLastReadPosition() { throw new NotImplementedException(); }

  /// <summary>
  /// Routes the specified document, using the document's current routing slip.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.route?view=word-pia"/>
  public void Route() { throw new NotImplementedException(); }

  /// <summary>
  /// Runs an auto macro that's stored in the specified document. If the specified auto macro doesn't exist, nothing happens.
  /// </summary>
  /// <param name="Which">Specifies which auto macro to run. Can be one of the AutoMacros constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.runautomacro?view=word-pia"/>
  public void RunAutoMacro(AutoMacros Which) { throw new NotImplementedException(); }

  /// <summary>
  /// Runs the Letter Wizard on the specified document.
  /// </summary>
  /// <param name="LetterContent">Specifies the content of the letter. Can be one of the WdLetterContent constants.</param>
  /// <param name="WizardMode">Specifies the mode of the wizard. Can be one of the WdLetterWizard constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.runletterwizard?view=word-pia"/>
  public void RunLetterWizard(object LetterContent, object WizardMode) { throw new NotImplementedException(); }

  /// <summary>
  /// Saves the specified document. If the document hasn't been saved before, the Save As dialog box prompts the
  /// user for a file name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.save?view=word-pia"/>
  public void Save() { throw new NotImplementedException(); }

  /// <summary>
  /// Saves the specified document with a new name or format. Some of the arguments for this method correspond to the options in the Save Asdialog box (File menu).
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <param name="Encoding">The encoding to use when saving the document.</param>
  /// <param name="InsertLineBreaks">Specifies whether to insert line breaks when saving the document.</param>
  /// <param name="AllowSubstitutions">Specifies whether to allow substitutions when saving the document.</param>
  /// <param name="LineEnding">Specifies the line ending to use when saving the document.</param>
  /// <param name="AddBiDiMarks">Specifies whether to add bidirectional marks when saving the document.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveas?view=word-pia"/>
  public void SaveAs
  (string FileName, SaveFormat FileFormat, bool LockComments, string Password, bool AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter, int Encoding, bool InsertLineBreaks, bool AllowSubstitutions,
    int LineEnding, bool AddBiDiMarks)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Saves the specified document with a new name or format. Some of the arguments for this method correspond to the options in the Save As dialog box (File tab).
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <param name="Encoding">The encoding to use when saving the document.</param>
  /// <param name="InsertLineBreaks">Specifies whether to insert line breaks when saving the document.</param>
  /// <param name="AllowSubstitutions">Specifies whether to allow substitutions when saving the document.</param>
  /// <param name="LineEnding">Specifies the line ending to use when saving the document.</param>
  /// <param name="AddBiDiMarks">Specifies whether to add bidirectional marks when saving the document.</param>
  /// <param name="CompatibilityMode">Specifies the compatibility mode to use when saving the document.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveas2?view=word-pia"/>
  public void SaveAs2
  (string FileName, SaveFormat FileFormat, bool LockComments, string Password, bool AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter, int Encoding, bool InsertLineBreaks, bool AllowSubstitutions,
    int LineEnding, bool AddBiDiMarks, object CompatibilityMode)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveas2000?view=word-pia"/>
  public void SaveAs2000
  (object FileName, object FileFormat, object LockComments, object Password, object AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Saves the group of quick styles currently in use.
  /// </summary>
  /// <param name="FileName">The name of the file to save the quick style set as.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveasquickstyleset?view=word-pia"/>
  public void SaveAsQuickStyleSet(string FileName) { throw new NotImplementedException(); }

  /// <summary>
  /// Saves the specified document with a new name or format.
  /// Some of the arguments for this method correspond to the options in the Save As dialog box (File tab).
  /// This method is reserved for internal use, and its behavior may change, or it may be removed in future versions of Microsoft Office Word.
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <param name="Encoding">The encoding to use when saving the document.</param>
  /// <param name="InsertLineBreaks">Specifies whether to insert line breaks when saving the document.</param>
  /// <param name="AllowSubstitutions">Specifies whether to allow substitutions when saving the document.</param>
  /// <param name="LineEnding">Specifies the line ending to use when saving the document.</param>
  /// <param name="AddBiDiMarks">Specifies whether to add bidirectional marks when saving the document.</param>
  /// <param name="CompatibilityMode">Specifies the compatibility mode to use when saving the document.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.savecopyas?view=word-pia"/>
  public void SaveCopyAs
  (string FileName, SaveFormat FileFormat, bool LockComments, string Password, bool AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter, int Encoding, bool InsertLineBreaks, bool AllowSubstitutions,
    int LineEnding, bool AddBiDiMarks, object CompatibilityMode)
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sblt?view=word-pia"/>
  public void sblt(string s) { throw new NotImplementedException(); }

  /// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.select?view=word-pia"/>
  public void Select() { throw new NotImplementedException(); }

  /// <summary>
  /// Selects all ranges for which the specified user or group of users has permission to modify.
  /// </summary>
  /// <param name="EditorID">The ID of the user or group of users.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectalleditableranges?view=word-pia"/>
  public void SelectAllEditableRanges(object EditorID) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a ContentControls collection that represents all the content controls in a document with the tag value specified in the Tag parameter. Read-only.
  /// </summary>
  /// <param name="Tag">The tag value of the content controls to return.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectcontentcontrolsbytag?view=word-pia"/>
  public ContentControls SelectContentControlsByTag(string Tag) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a ContentControls collection that represents all the content controls in a document with the title specified in the Title parameter. Read-only.
  /// </summary>
  /// <param name="Title">The title of the content controls to return.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectcontentcontrolsbytitle?view=word-pia"/>
  public ContentControls SelectContentControlsByTitle(string Title) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns a ContentControls collection that represents all content controls in a document that are linked to the specific custom XML node in the document's XML data store as specified by the Node parameter. Read-only.
  /// </summary>
  /// <param name="Node">The custom XML node to which the content controls are linked.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectlinkedcontrols?view=word-pia"/>
  public ContentControls SelectLinkedControls(Core.CustomXMLNode Node) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns an XMLNodes collection that represents all the specified nodes in the order in which they appear in the document.
  /// </summary>
  /// <param name="XPath">The XPath expression to evaluate.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="FastSearchSkippingTextNodes">Specifies whether to use fast search by skipping text nodes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectnodes?view=word-pia"/>
  public XMLNodes SelectNodes(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns an XMLNode object that represents a node in the specified document.
  /// </summary>
  /// <param name="XPath">The XPath expression to evaluate.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="FastSearchSkippingTextNodes">Specifies whether to use fast search by skipping text nodes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectsinglenode?view=word-pia"/>
  public XMLNode SelectSingleNode(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes) { throw new NotImplementedException(); }

  /// <summary>
  /// Returns all of the content controls in a document that are not linked to an XML node in the document's XML data store. Read-only.
  /// </summary>
  /// <param name="Stream">The custom XML part to which the content controls are linked.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectunlinkedcontrols?view=word-pia"/>
  public ContentControls SelectUnlinkedControls(Core.CustomXMLPart Stream) { throw new NotImplementedException(); }

  /// <summary>
  /// Sends the specified document as a fax, without any user interaction.
  /// </summary>
  /// <param name="Address">The fax number to send the document to.</param>
  /// <param name="Subject">The subject of the fax.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendfax?view=word-pia"/>
  public void SendFax(string Address, string Subject) { throw new NotImplementedException(); }

  /// <summary>
  /// Sends a document to a fax service provider, who faxes the document to one or more specified recipients.
  /// </summary>
  /// <param name="Recipients">The recipients to send the fax to.</param>
  /// <param name="Subject">The subject of the fax.</param>
  /// <param name="ShowMessage">Specifies whether to show a message when sending the fax.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendfaxoverinternet?view=word-pia"/>
  public void SendFaxOverInternet(object Recipients, string Subject, bool ShowMessage) { throw new NotImplementedException(); }

  /// <summary>
  /// Sends a document in an e-mail message for review by the specified recipients.
  /// </summary>
  /// <param name="Recipients">The recipients to send the document to for review.</param>
  /// <param name="Subject">The subject of the review request.</param>
  /// <param name="ShowMessage">Specifies whether to show a message when sending the review request.</param>
  /// <param name="IncludeAttachment">Specifies whether to include the document as an attachment.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendforreview?view=word-pia"/>
  public void SendForReview(object Recipients, string Subject, bool ShowMessage, bool IncludeAttachment) { throw new NotImplementedException(); }

  /// <summary>
  /// Opens a message window for sending the specified document through Microsoft Exchange.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendmail?view=word-pia"/>
  public void SendMail() { throw new NotImplementedException(); }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <param name="FileFormat">The file format to use when sending the mailer.</param>
  /// <param name="Priority">The priority of the mailer.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendmailer?view=word-pia"/>
  public void SendMailer(object FileFormat, object Priority) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the compatibility mode for the document.
  /// </summary>
  /// <param name="Mode">The compatibility mode to set for the document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setcompatibilitymode?view=word-pia"/>
  public void SetCompatibilityMode(int Mode) { throw new NotImplementedException(); }

  /// <summary>
  /// Specifies the table style to use for newly created tables in a document.
  /// </summary>
  /// <param name="Style">The table style to set as the default for newly created tables.</param>
  /// <param name="SetInTemplate">Specifies whether to set the default table style in the template.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setdefaulttablestyle?view=word-pia"/>
  public void SetDefaultTableStyle(object Style, bool SetInTemplate) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts the contents of the specified LetterContent object into a document.
  /// </summary>
  /// <param name="LetterContent">The LetterContent object that contains the letter elements to insert into the document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setlettercontent?view=word-pia"/>
  public void SetLetterContent(object LetterContent) { throw new NotImplementedException(); }

  /// <summary>
  /// Sets the options Microsoft Word uses for encrypting documents with passwords.
  /// </summary>
  /// <param name="PasswordEncryptionProvider">The provider to use for password encryption.</param>
  /// <param name="PasswordEncryptionAlgorithm">The algorithm to use for password encryption.</param>
  /// <param name="PasswordEncryptionKeyLength">The key length to use for password encryption.</param>
  /// <param name="PasswordEncryptionFileProperties">Specifies whether to encrypt file properties.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setpasswordencryptionoptions?view=word-pia"/>
  public void SetPasswordEncryptionOptions
  (string PasswordEncryptionProvider, string PasswordEncryptionAlgorithm, int PasswordEncryptionKeyLength,
    bool PasswordEncryptionFileProperties) { throw new NotImplementedException(); }

  /// <summary>
  /// Toggles form design mode on or off.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.toggleformsdesign?view=word-pia"/>
  public void ToggleFormsDesign() { throw new NotImplementedException(); }

  /// <summary>
  /// Applies the specified Extensible Stylesheet Language Transformation (XSLT) file to the specified document and replaces the document with the results.
  /// </summary>
  /// <param name="Path">The path to the XSLT file to apply to the document.</param>
  /// <param name="DataOnly">Specifies whether to apply the transformation to the data only.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.transformdocument?view=word-pia"/>
  public void TransformDocument(string Path, bool DataOnly) { throw new NotImplementedException(); }

  /// <summary>
  /// Undoes the last action or a sequence of actions, which are displayed in the Undo list. Returns True if the actions were successfully undone.
  /// </summary>
  /// <param name="Times">The number of actions to undo.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.undo?view=word-pia"/>
  public bool Undo(int Times) { throw new NotImplementedException(); }

  /// <summary>
  /// Clears the list of actions that can be undone for the specified document. Corresponds to the list of items
  /// that appears when you click the arrow beside the Undo button on the Standard toolbar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.undoclear?view=word-pia"/>
  public void UndoClear() { throw new NotImplementedException(); }

  /// <summary>
  /// Reverses the effect of UnfreezeLayout(), and enables line breaks to change and ink annotations to move when
  /// you resize the Web browser window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.unfreezelayout?view=word-pia"/>
  public void UnfreezeLayout() { throw new NotImplementedException(); }

  /// <summary>
  /// Removes protection from the specified document. If the document isn't protected, this method generates an error.
  /// </summary>
  /// <param name="Password">The password used to protect the document, if any. If the document isn't protected with a password, this argument is ignored.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.unprotect?view=word-pia"/>
  public void Unprotect(string Password) { throw new NotImplementedException(); }

  /// <summary>
  /// Copies all styles from the attached template into the document, overwriting any existing styles in the
  /// document that have the same name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.updatestyles?view=word-pia"/>
  public void UpdateStyles() { throw new NotImplementedException(); }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.updatesummaryproperties?view=word-pia"/>
  public void UpdateSummaryProperties() { throw new NotImplementedException(); }

  /// <summary>
  /// Displays the code window for the selected ActiveX control in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.viewcode?view=word-pia"/>
  public void ViewCode() { throw new NotImplementedException(); }

  /// <summary>
  /// Displays the property window for the selected ActiveX control in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.viewpropertybrowser?view=word-pia"/>
  public void ViewPropertyBrowser() { throw new NotImplementedException(); }

  /// <summary>
  /// Displays a preview of the current document as it would look if saved as a Web page.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.webpagepreview?view=word-pia"/>
  public void WebPagePreview() { throw new NotImplementedException(); }

}
