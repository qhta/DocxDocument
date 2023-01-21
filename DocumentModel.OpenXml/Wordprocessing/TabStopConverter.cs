namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  private static DMW.TabStopKind? GetVal(DXW.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TabStopValues, DMW.TabStopKind>(openXmlElement?.Val?.Value);
  }
  
  private static void SetVal(DXW.TabStop openXmlElement, DMW.TabStopKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TabStopValues, DMW.TabStopKind>(value);
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  private static DMW.TabStopLeaderCharKind? GetLeader(DXW.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues, DMW.TabStopLeaderCharKind>(openXmlElement?.Leader?.Value);
  }
  
  private static void SetLeader(DXW.TabStop openXmlElement, DMW.TabStopLeaderCharKind? value)
  {
    openXmlElement.Leader = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues, DMW.TabStopLeaderCharKind>(value);
  }
  
  /// <summary>
  /// Tab Stop Position
  /// </summary>
  private static Int32? GetPosition(DXW.TabStop openXmlElement)
  {
    return openXmlElement.Position?.Value;
  }
  
  private static void SetPosition(DXW.TabStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  public static DMW.TabStop? CreateModelElement(DXW.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TabStop();
      value.Val = GetVal(openXmlElement);
      value.Leader = GetLeader(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TabStop? value)
    where OpenXmlElementType: DXW.TabStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetLeader(openXmlElement, value?.Leader);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}
