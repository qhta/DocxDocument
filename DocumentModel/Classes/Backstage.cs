namespace DocumentModel;

/// <summary>
///   Defines the Backstage Class.
/// </summary>
public class Backstage
{
  /// <summary>
  ///   onShow, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnShow { get; set; }

  /// <summary>
  ///   onHide, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnHide { get; set; }

  public BackstageTab? BackstageTab { get; set; }

  public BackstageFastCommandButton? BackstageFastCommandButton { get; set; }
}