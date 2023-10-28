namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label.
/// </summary>
public partial class ColorTransformStyleLabel
{
  
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Fill Color List.
  /// </summary>
  public DMDD.FillColorList? FillColorList { get; set; }
  
  
  /// <summary>
  ///   Line Color List.
  /// </summary>
  public DMDD.LineColorList? LineColorList { get; set; }
  
  
  /// <summary>
  ///   Effect Color List.
  /// </summary>
  public DMDD.EffectColorList? EffectColorList { get; set; }
  
  
  /// <summary>
  ///   Text Line Color List.
  /// </summary>
  public DMDD.TextLineColorList? TextLineColorList { get; set; }
  
  
  /// <summary>
  ///   Text Fill Color List.
  /// </summary>
  public DMDD.TextFillColorList? TextFillColorList { get; set; }
  
  
  /// <summary>
  ///   Text Effect Color List.
  /// </summary>
  public DMDD.TextEffectColorList? TextEffectColorList { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMDD.ExtensionList? ExtensionList { get; set; }
  
}
