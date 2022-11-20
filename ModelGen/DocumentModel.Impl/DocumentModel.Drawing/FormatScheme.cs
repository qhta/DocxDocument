namespace DocumentModel.Drawing;

/// <summary>
/// Format Scheme.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBackgroundFillStyleList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectStyleList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IFillStyleList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILineStyleList))]
public class FormatScheme: IFormatScheme
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  public IFillStyleList? FillStyleList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public ILineStyleList? LineStyleList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public IEffectStyleList? EffectStyleList
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public IBackgroundFillStyleList? BackgroundFillStyleList
  {
    get;
    set;
  }
  
}
