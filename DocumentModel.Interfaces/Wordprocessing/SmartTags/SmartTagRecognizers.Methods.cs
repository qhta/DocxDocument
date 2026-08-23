namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizers?view=word-pia"/>
public partial interface ISmartTagRecognizers : IModelObject
{
  /// <summary>
  /// Reloads all recognizers installed on a user's computer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizers.reloadrecognizers?view=word-pia"/>
  public void ReloadRecognizers();
}
