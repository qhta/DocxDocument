namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of actions for an individual smart tag or a type of smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagactions?view=word-pia"/>
public interface ISmartTagActions : IInteropObject, IInteropCollection<SmartTagAction>
{


  #region methods

/// <summary>
  /// Forces a reload of all smart tag actions related to a specific smart tag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagactions.reloadactions?view=word-pia"/>
  public void ReloadActions();

  #endregion methods
}
