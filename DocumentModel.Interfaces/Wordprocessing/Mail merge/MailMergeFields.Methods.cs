namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields?view=word-pia"/>
public partial interface IMailMergeFields : IModelObject
{
  /// <summary>
  /// Inserts a merge field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the field is inserted.</param>
  /// <param name="Name">The name of the mail merge field.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.add?view=word-pia"/>
  public IMailMergeField Add(IRange Range, string Name);

  /// <summary>
  /// Inserts an ASK field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the ASK field is inserted.</param>
  /// <param name="Name">The name of the ASK field.</param>
  /// <param name="Prompt">The prompt text for the ASK field.</param>
  /// <param name="DefaultAskText">The default text for the ASK field.</param>
  /// <param name="AskOnce">true to prompt only once; otherwise, false.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addask?view=word-pia"/>
  public IMailMergeField AddAsk(IRange Range, string Name, object Prompt, object DefaultAskText, object AskOnce);

  /// <summary>
  /// Inserts a FILLIN field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the FILLIN field is inserted.</param>
  /// <param name="Prompt">The prompt text for the FILLIN field.</param>
  /// <param name="DefaultFillInText">The default text for the FILLIN field.</param>
  /// <param name="AskOnce">true to prompt only once; otherwise, false.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addfillin?view=word-pia"/>
  public IMailMergeField AddFillIn(IRange Range, object Prompt, object DefaultFillInText, object AskOnce);

  /// <summary>
  /// Inserts an IF field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the IF field is inserted.</param>
  /// <param name="MergeField">The merge field to compare.</param>
  /// <param name="Comparison">The comparison operator.</param>
  /// <param name="CompareTo">The value to compare to.</param>
  /// <param name="TrueAutoText">The AutoText entry to insert if true.</param>
  /// <param name="TrueText">The text to insert if true.</param>
  /// <param name="FalseAutoText">The AutoText entry to insert if false.</param>
  /// <param name="FalseText">The text to insert if false.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addif?view=word-pia"/>
  public IMailMergeField AddIf(IRange Range, string MergeField, MailMergeComparison Comparison, object CompareTo, object TrueAutoText, object TrueText, object FalseAutoText, object FalseText);

  /// <summary>
  /// Inserts a MERGEREC field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the MERGEREC field is inserted.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addmergerec?view=word-pia"/>
  public IMailMergeField AddMergeRec(IRange Range);

  /// <summary>
  /// Inserts a MERGESEQ field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the MERGESEQ field is inserted.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addmergeseq?view=word-pia"/>
  public IMailMergeField AddMergeSeq(IRange Range);

  /// <summary>
  /// Inserts a NEXT field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the NEXT field is inserted.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addnext?view=word-pia"/>
  public IMailMergeField AddNext(IRange Range);

  /// <summary>
  /// Inserts a NEXTIF field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the NEXTIF field is inserted.</param>
  /// <param name="MergeField">The merge field to compare.</param>
  /// <param name="Comparison">The comparison operator.</param>
  /// <param name="CompareTo">The value to compare to.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addnextif?view=word-pia"/>
  public IMailMergeField AddNextIf(IRange Range, string MergeField, MailMergeComparison Comparison, object CompareTo);

  /// <summary>
  /// Inserts a SET field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the SET field is inserted.</param>
  /// <param name="Name">The name of the SET field.</param>
  /// <param name="ValueText">The value text for the SET field.</param>
  /// <param name="ValueAutoText">The AutoText entry for the SET field.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addset?view=word-pia"/>
  public IMailMergeField AddSet(IRange Range, string Name, string ValueText, IAutoTextEntry ValueAutoText);

  /// <summary>
  /// Inserts a SKIPIF field at the specified range.
  /// </summary>
  /// <param name="Range">The range where the SKIPIF field is inserted.</param>
  /// <param name="MergeField">The merge field to compare.</param>
  /// <param name="Comparison">The comparison operator.</param>
  /// <param name="CompareTo">The value to compare to.</param>
  /// <returns>The created <see cref="IMailMergeField"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailmergefields.addskipif?view=word-pia"/>
  public IMailMergeField AddSkipIf(IRange Range, string MergeField, MailMergeComparison Comparison, object CompareTo);
}
