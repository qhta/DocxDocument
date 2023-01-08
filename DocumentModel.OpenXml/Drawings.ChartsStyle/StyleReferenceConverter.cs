namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public static class StyleReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.ListOf<String>? GetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement, DocumentModel.ListOf<String>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
