namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedButton))]
public class DialogBoxLauncher: IDialogBoxLauncher
{
  /// <summary>
  /// UnsizedButton.
  /// </summary>
  public IUnsizedButton? UnsizedButton
  {
    get;
    set;
  }
  
}
