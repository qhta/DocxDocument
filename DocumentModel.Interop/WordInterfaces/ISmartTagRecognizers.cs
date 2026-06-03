namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SmartTagRecognizer objects that represent recognition engines that label data with types of
/// information as you work in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizers?view=word-pia"/>
public interface ISmartTagRecognizers : IInteropObject, IInteropCollection<ISmartTagRecognizer>
{


  #region methods

/// <summary>
  /// Reloads all recognizers installed on a user's computer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagrecognizers.reloadrecognizers?view=word-pia"/>
  public void ReloadRecognizers();

  #endregion methods
}
