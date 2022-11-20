namespace DocumentModel.Office2013.Word.Drawing;

/// <summary>
/// Defines the WebVideoProperty Class.
/// </summary>
public class WebVideoProperty: IWebVideoProperty
{
  /// <summary>
  /// embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public string? EmbeddedHtml
  {
    get;
    set;
  }
  
  /// <summary>
  /// h, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// w, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Width
  {
    get;
    set;
  }
  
}
