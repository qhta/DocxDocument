namespace DocumentModel.UI;

/// <summary>
///   Defines the DialogBoxLauncher Class.
/// </summary>
public interface DialogBoxLauncher: IModelElement
{
  /// <summary>
  ///   UnsizedButton.
  /// </summary>
  public UnsizedButton? UnsizedButton { get; set; }
}