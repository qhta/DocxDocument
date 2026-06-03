namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mail merge field objects in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields?view=word-pia"/>
public partial class MailMergeFields : InteropCollection<MailMergeField>
{


  #region methods

/// <summary>
  /// Inserts a merge field at the specified range.
  /// </summary>
  /// <param name="range">The range where the field is inserted.</param>
  /// <param name="name">The name of the mail merge field.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.add?view=word-pia"/>
  public MailMergeField Add(Range range, string name) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts an ASK field at the specified range.
  /// </summary>
  /// <param name="range">The range where the ASK field is inserted.</param>
  /// <param name="name">The name of the ASK field.</param>
  /// <param name="prompt">The prompt text for the ASK field.</param>
  /// <param name="defaultAskText">The default text for the ASK field.</param>
  /// <param name="askOnce">true to prompt only once; otherwise, false.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addask?view=word-pia"/>
  public MailMergeField AddAsk(Range range, string name, object prompt, object defaultAskText, object askOnce) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a FILLIN field at the specified range.
  /// </summary>
  /// <param name="range">The range where the FILLIN field is inserted.</param>
  /// <param name="prompt">The prompt text for the FILLIN field.</param>
  /// <param name="defaultFillInText">The default text for the FILLIN field.</param>
  /// <param name="askOnce">true to prompt only once; otherwise, false.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addfillin?view=word-pia"/>
  public MailMergeField AddFillIn(Range range, object prompt, object defaultFillInText, object askOnce) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts an IF field at the specified range.
  /// </summary>
  /// <param name="range">The range where the IF field is inserted.</param>
  /// <param name="mergeField">The merge field to compare.</param>
  /// <param name="comparison">The comparison operator.</param>
  /// <param name="compareTo">The value to compare to.</param>
  /// <param name="trueAutoText">The AutoText entry to insert if true.</param>
  /// <param name="trueText">The text to insert if true.</param>
  /// <param name="falseAutoText">The AutoText entry to insert if false.</param>
  /// <param name="falseText">The text to insert if false.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addif?view=word-pia"/>
  public MailMergeField AddIf(Range range, string mergeField, WdMailMergeComparison comparison, object compareTo, object trueAutoText, object trueText, object falseAutoText, object falseText) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a MERGEREC field at the specified range.
  /// </summary>
  /// <param name="range">The range where the MERGEREC field is inserted.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addmergerec?view=word-pia"/>
  public MailMergeField AddMergeRec(Range range) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a MERGESEQ field at the specified range.
  /// </summary>
  /// <param name="range">The range where the MERGESEQ field is inserted.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addmergeseq?view=word-pia"/>
  public MailMergeField AddMergeSeq(Range range) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a NEXT field at the specified range.
  /// </summary>
  /// <param name="range">The range where the NEXT field is inserted.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addnext?view=word-pia"/>
  public MailMergeField AddNext(Range range) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a NEXTIF field at the specified range.
  /// </summary>
  /// <param name="range">The range where the NEXTIF field is inserted.</param>
  /// <param name="mergeField">The merge field to compare.</param>
  /// <param name="comparison">The comparison operator.</param>
  /// <param name="compareTo">The value to compare to.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addnextif?view=word-pia"/>
  public MailMergeField AddNextIf(Range range, string mergeField, WdMailMergeComparison comparison, object compareTo) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a SET field at the specified range.
  /// </summary>
  /// <param name="range">The range where the SET field is inserted.</param>
  /// <param name="name">The name of the SET field.</param>
  /// <param name="valueText">The value text for the SET field.</param>
  /// <param name="valueAutoText">The AutoText entry for the SET field.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addset?view=word-pia"/>
  public MailMergeField AddSet(Range range, string name, string valueText, AutoTextEntry valueAutoText) { throw new NotImplementedException(); }

  /// <summary>
  /// Inserts a SKIPIF field at the specified range.
  /// </summary>
  /// <param name="range">The range where the SKIPIF field is inserted.</param>
  /// <param name="mergeField">The merge field to compare.</param>
  /// <param name="comparison">The comparison operator.</param>
  /// <param name="compareTo">The value to compare to.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addskipif?view=word-pia"/>
  public MailMergeField AddSkipIf(Range range, string mergeField, WdMailMergeComparison comparison, object compareTo) { throw new NotImplementedException(); }

  #endregion methods
}
