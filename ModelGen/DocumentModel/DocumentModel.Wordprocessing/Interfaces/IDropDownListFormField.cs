namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public interface IDropDownListFormField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public System.Int32? DropDownListSelection { get ; set; }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public System.Int32? DefaultDropDownListItemIndex { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.String>? ListEntryFormFields { get ; set; }
  
}
