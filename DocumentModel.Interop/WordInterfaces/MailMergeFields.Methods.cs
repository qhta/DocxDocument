namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields?view=word-pia"/>
public partial interface MailMergeFields
{
  /// <summary>
  /// Adds a mail merge field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the field is inserted.</param>
  /// <param name="Name">The name of the mail merge field.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.add?view=word-pia"/>
  public MailMergeField Add(Range Range, string Name);

  /// <summary>
  /// Adds an ASK field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the ASK field is inserted.</param>
  /// <param name="Name">The name of the ASK field.</param>
  /// <param name="Prompt">The prompt text for the ASK field.</param>
  /// <param name="DefaultAskText">The default text for the ASK field.</param>
  /// <param name="AskOnce">true to prompt only once; otherwise, false.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addask?view=word-pia"/>
  public MailMergeField AddAsk(Range Range, string Name, object Prompt, object DefaultAskText, object AskOnce);

  /// <summary>
  /// Adds a FILLIN field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the FILLIN field is inserted.</param>
  /// <param name="Prompt">The prompt text for the FILLIN field.</param>
  /// <param name="DefaultFillInText">The default text for the FILLIN field.</param>
  /// <param name="AskOnce">true to prompt only once; otherwise, false.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addfillin?view=word-pia"/>
  public MailMergeField AddFillIn(Range Range, object Prompt, object DefaultFillInText, object AskOnce);

  /// <summary>
  /// Adds an IF field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the IF field is inserted.</param>
  /// <param name="MergeField">The merge field to compare.</param>
  /// <param name="Comparison">The comparison operator.</param>
  /// <param name="CompareTo">The value to compare to.</param>
  /// <param name="TrueAutoText">The AutoText entry to insert if true.</param>
  /// <param name="TrueText">The text to insert if true.</param>
  /// <param name="FalseAutoText">The AutoText entry to insert if false.</param>
  /// <param name="FalseText">The text to insert if false.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addif?view=word-pia"/>
  public MailMergeField AddIf(Range Range, string MergeField, WdMailMergeComparison Comparison, object CompareTo, object TrueAutoText, object TrueText, object FalseAutoText, object FalseText);

  /// <summary>
  /// Adds a MERGEREC field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the MERGEREC field is inserted.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addmergerec?view=word-pia"/>
  public MailMergeField AddMergeRec(Range Range);

  /// <summary>
  /// Adds a MERGESEQ field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the MERGESEQ field is inserted.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addmergeseq?view=word-pia"/>
  public MailMergeField AddMergeSeq(Range Range);

  /// <summary>
  /// Adds a NEXT field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the NEXT field is inserted.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addnext?view=word-pia"/>
  public MailMergeField AddNext(Range Range);

  /// <summary>
  /// Adds a NEXTIF field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the NEXTIF field is inserted.</param>
  /// <param name="MergeField">The merge field to compare.</param>
  /// <param name="Comparison">The comparison operator.</param>
  /// <param name="CompareTo">The value to compare to.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addnextif?view=word-pia"/>
  public MailMergeField AddNextIf(Range Range, string MergeField, WdMailMergeComparison Comparison, object CompareTo);

  /// <summary>
  /// Adds a SET field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the SET field is inserted.</param>
  /// <param name="Name">The name of the SET field.</param>
  /// <param name="ValueText">The value text for the SET field.</param>
  /// <param name="ValueAutoText">The AutoText entry for the SET field.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addset?view=word-pia"/>
  public MailMergeField AddSet(Range Range, string Name, string ValueText, AutoTextEntry ValueAutoText);

  /// <summary>
  /// Adds a SKIPIF field to the specified range.
  /// </summary>
  /// <param name="Range">The range where the SKIPIF field is inserted.</param>
  /// <param name="MergeField">The merge field to compare.</param>
  /// <param name="Comparison">The comparison operator.</param>
  /// <param name="CompareTo">The value to compare to.</param>
  /// <returns>The created <see cref="MailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addskipif?view=word-pia"/>
  public MailMergeField AddSkipIf(Range Range, string MergeField, WdMailMergeComparison Comparison, object CompareTo);
}
