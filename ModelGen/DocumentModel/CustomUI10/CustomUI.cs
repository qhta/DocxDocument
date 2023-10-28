namespace DocumentModel.CustomUI10;


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
  public DMCUI10.Commands? Commands { get; set; }
  
  
  /// <summary>
  ///   Ribbon.
  /// </summary>
  public DMCUI10.Ribbon? Ribbon { get; set; }
  
  
  /// <summary>
  ///   Backstage.
  /// </summary>
  public DMCUI10.Backstage? Backstage { get; set; }
  
  
  /// <summary>
  ///   ContextMenus.
  /// </summary>
  public DMCUI10.ContextMenus? ContextMenus { get; set; }
  
}
