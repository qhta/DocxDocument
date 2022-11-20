namespace DocumentModel.Office2010.CustomUI;

/// <summary>
/// Defines the DialogBoxLauncher Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.CustomUI.IButtonRegular))]
public class DialogBoxLauncher: IDialogBoxLauncher
{
  /// <summary>
  /// ButtonRegular.
  /// </summary>
  public IButtonRegular? ButtonRegular
  {
    get;
    set;
  }
  
}
