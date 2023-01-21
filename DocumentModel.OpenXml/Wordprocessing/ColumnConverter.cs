namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public static class ColumnConverter
{
  /// <summary>
  /// Column Width
  /// </summary>
  private static String? GetWidth(DXW.Column openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static void SetWidth(DXW.Column openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Width = new StringValue { Value = value };
    else
      openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  private static String? GetSpace(DXW.Column openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }
  
  private static void SetSpace(DXW.Column openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Space = new StringValue { Value = value };
    else
      openXmlElement.Space = null;
  }
  
  public static DMW.Column? CreateModelElement(DXW.Column? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Column();
      value.Width = GetWidth(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Column? value)
    where OpenXmlElementType: DXW.Column, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetSpace(openXmlElement, value?.Space);
      return openXmlElement;
    }
    return default;
  }
}
