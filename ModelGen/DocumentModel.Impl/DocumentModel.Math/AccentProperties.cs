namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IAccentChar))]
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
public class AccentProperties: IAccentProperties
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  public IAccentChar? AccentChar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
