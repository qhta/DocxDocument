namespace DocumentModel;

/// <summary>
///   Defines the DialogBoxLauncher Class.
/// </summary>
public interface DialogBoxLauncher: IModelElement
{
  /// <summary>
  ///   ButtonRegular.
  /// </summary>
  public ButtonRegular? ButtonRegular { get; set; }
}