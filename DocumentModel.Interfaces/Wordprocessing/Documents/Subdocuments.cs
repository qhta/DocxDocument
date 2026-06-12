namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Subdocument objects that represent the subdocuments in a range or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments?view=word-pia"/>
public partial interface ISubdocuments : IModelCollection<ISubdocument>
{
  /// <summary>
  /// True if the subdocuments in the specified document are expanded.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.subdocuments.expanded?view=word-pia"/>
  public bool Expanded { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
