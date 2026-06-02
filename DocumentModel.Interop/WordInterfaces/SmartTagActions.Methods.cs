namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagactions?view=word-pia"/>
public partial interface ISmartTagActions
{
  /// <summary>
  /// Forces a reload of all smart tag actions related to a specific smart tag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagactions.reloadactions?view=word-pia"/>
  public void ReloadActions();
}
