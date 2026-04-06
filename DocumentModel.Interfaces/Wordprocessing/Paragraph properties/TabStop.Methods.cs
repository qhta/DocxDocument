namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop?view=word-pia"/>
public partial interface ITabStop: IModelObject
{
  /// <summary>
  /// Removes the specified custom tab stop.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.clear?view=word-pia"/>
  public void Clear();
}
