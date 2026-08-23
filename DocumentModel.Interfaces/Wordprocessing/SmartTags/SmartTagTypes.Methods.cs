namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtypes?view=word-pia"/>
public partial interface ISmartTagTypes : IModelObject
{
  /// <summary>
  /// Reloads all smart tag actions and recognizers installed on a user's computer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtypes.reloadall?view=word-pia"/>
  public void ReloadAll();
}
