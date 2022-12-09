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
    get => (UInt32?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
