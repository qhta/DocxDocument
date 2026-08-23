namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentry?view=word-pia"/>
public partial interface IContentControlListEntry : IModelObject
{
  /// <summary>
  /// Deletes the specified item in a combo box or drop-down list content control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentry.delete?view=word-pia"/>
  public void Delete();
}
