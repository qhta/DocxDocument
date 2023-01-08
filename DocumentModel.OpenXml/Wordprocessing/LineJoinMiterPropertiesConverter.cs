namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public static class LineJoinMiterPropertiesConverter
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLimit(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLimit(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
