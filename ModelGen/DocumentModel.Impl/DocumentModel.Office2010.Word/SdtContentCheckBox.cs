namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IChecked))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICheckedState))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IUncheckedState))]
public class SdtContentCheckBox: ISdtContentCheckBox
{
  /// <summary>
  /// Checked.
  /// </summary>
  public DocumentModel.Office2010.Word.IChecked? Checked
  {
    get;
    set;
  }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public ICheckedState? CheckedState
  {
    get;
    set;
  }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public IUncheckedState? UncheckedState
  {
    get;
    set;
  }
  
}
