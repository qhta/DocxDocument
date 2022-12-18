namespace DocumentModel.Drawings.ChartsStyle;

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
  
  public StyleReferenceImpl(): base() {}
  
  public StyleReferenceImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.ListOf<System.String>? Modifiers
  {
    get
    {
      if (OpenXmlElement?.Modifiers != null)
        return new DocumentModel.ListOf<System.String>(OpenXmlElement.Modifiers.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Modifiers = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.StringValue>(value.Items.Select(item => new DocumentFormat.OpenXml.StringValue(item)));
    else
      OpenXmlElement.Modifiers = null;
      }
    }
  }
  
}
