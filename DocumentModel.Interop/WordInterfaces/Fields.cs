namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Field objects that represent all the fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields?view=word-pia"/>
public partial interface IFields : IInteropObject, IInteropCollection<Field>
{
  /// <summary>
  /// Determines if all fields in the <see cref="Fields"/> collection are locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields.locked?view=word-pia"/>
  public int Locked { get; set; }


  #region methods

/// <summary>
  /// Toggles the display of the fields between field codes and field results.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields.toggleshowcodes?view=word-pia"/>
  public void ToggleShowCodes();

  #endregion methods
}
