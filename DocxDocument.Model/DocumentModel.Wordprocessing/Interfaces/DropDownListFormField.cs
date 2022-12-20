namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public partial interface DropDownListFormField
{
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public Int32? DropDownListSelection { get; set; }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public Int32? DefaultDropDownListItemIndex { get; set; }
  
  public Collection<System.String>? ListEntryFormFields { get; set; }
  
}
