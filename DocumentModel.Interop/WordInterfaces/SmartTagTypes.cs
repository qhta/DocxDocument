namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of SmartTagType objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtypes?view=word-pia"/>
public partial interface ISmartTagTypes : IInteropObject, IInteropCollection<SmartTagType>
{


  #region methods

/// <summary>
  /// Reloads all smart tag actions and recognizers installed on a user's computer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtypes.reloadall?view=word-pia"/>
  public void ReloadAll();

  #endregion methods
}
