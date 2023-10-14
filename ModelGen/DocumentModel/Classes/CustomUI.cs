namespace DocumentModel;


/// <summary>
///   Defines the CustomUI Class.
/// </summary>
public partial class CustomUI
{
  
  /// <summary>
  ///   onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnLoad { get; set; }
  
  
  /// <summary>
  ///   loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  public String? LoadImage { get; set; }
  
  
  /// <summary>
  ///   Commands.
  /// </summary>
  public DM.Commands? Commands { get; set; }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  public DM.Ribbon? Ribbon { get; set; }
  
  
  /// <summary>
  ///   Backstage.
  /// </summary>
  public DM.Backstage? Backstage { get; set; }
  
  
  /// <summary>
  ///   ContextMenus.
  /// </summary>
  public DM.ContextMenus? ContextMenus { get; set; }
  
}
