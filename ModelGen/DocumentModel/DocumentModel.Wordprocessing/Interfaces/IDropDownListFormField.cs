namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDropDownListSelection))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IListEntryFormField))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDefaultDropDownListItemIndex))]
public interface IDropDownListFormField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public IDropDownListSelection? DropDownListSelection { get ; set; }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public IDefaultDropDownListItemIndex? DefaultDropDownListItemIndex { get ; set; }
  
}
