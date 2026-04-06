using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of files returned by a search.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia"/>
public partial interface IFoundFiles: IModelObject
{
  /// <summary>
  /// Returns an enumerator that iterates through the found files.
  /// </summary>
  /// <returns>An enumerator for the collection.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();
}

