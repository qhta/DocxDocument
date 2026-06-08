namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Drop-Down IList Form IField Properties.
/// </summary>
public class DropDownListFormField: ModelElement
{
  /// <summary>
  ///   Drop-Down IList ISelection.
  /// </summary>
  public Int32? DropDownListSelection { get; set; }

  /// <summary>
  ///   Default Drop-Down IList Item IIndex.
  /// </summary>
  public Int32? DefaultDropDownListItemIndex { get; set; }

  public Collection<String>? ListEntryFormFields { get; set; }
}
