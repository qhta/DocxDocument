namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public class StyleReferenceImpl: ModelElementImpl, StyleReference
{
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers
  {
    get;
    set;
  }
  
}
