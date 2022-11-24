namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public interface IDropDownListFormField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public IDropDownListSelection? DropDownListSelection { get ; set; }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public Int32Value? DefaultDropDownListItemIndex { get ; set; }
  
}
