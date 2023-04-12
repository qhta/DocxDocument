namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Drop-Down List Form Field Properties.
/// </summary>
public class DropDownListFormField: ModelElement
{
  /// <summary>
  ///   Drop-Down List Selection.
  /// </summary>
  public Int32? DropDownListSelection { get; set; }

  /// <summary>
  ///   Default Drop-Down List Item Index.
  /// </summary>
  public Int32? DefaultDropDownListItemIndex { get; set; }

  public Collection<String>? ListEntryFormFields { get; set; }
}