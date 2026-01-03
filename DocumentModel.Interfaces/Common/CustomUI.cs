namespace DocumentModel;

/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public interface CustomUI: IModelElement
{
  /// <summary>
  ///   onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnLoad { get; set; }
  /// <summary>
  ///   loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  public string? LoadImage { get; set; }
  /// <summary>
  ///   Commands.
  /// </summary>
  public Commands? Commands { get; set; }
  /// <summary>
  ///   Ribbon.
  /// </summary>
  public Ribbon? Ribbon { get; set; }
  /// <summary>
  ///   IBackstage.
  /// </summary>
  public Backstage? Backstage { get; set; }
  /// <summary>
  ///   ContextMenus.
  /// </summary>
  public ContextMenus? ContextMenus { get; set; }
}