namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public static class NonVisualInkContentPartPropertiesConverter
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetIsComment(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement)
  {
    return openXmlElement?.IsComment?.Value;
  }
  
  private static void SetIsComment(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.IsComment = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.IsComment = null;
  }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  private static DMDraws.ContentPartLocks? GetContentPartLocks(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.ContentPartLocks>();
    if (itemElement != null)
      return DMXDraws.ContentPartLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetContentPartLocks(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDraws.ContentPartLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ContentPartLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ContentPartLocksConverter.CreateOpenXmlElement<DXO2010Draw.ContentPartLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDraws.OfficeArtExtensionList2? GetOfficeArtExtensionList(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDraws.OfficeArtExtensionList2Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2010DrawChartDraw.NonVisualInkContentPartProperties openXmlElement, DMDraws.OfficeArtExtensionList2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OfficeArtExtensionList2Converter.CreateOpenXmlElement<DXO2010Draw.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.NonVisualInkContentPartProperties? CreateModelElement(DXO2010DrawChartDraw.NonVisualInkContentPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.NonVisualInkContentPartProperties();
      value.IsComment = GetIsComment(openXmlElement);
      value.ContentPartLocks = GetContentPartLocks(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NonVisualInkContentPartProperties? value)
    where OpenXmlElementType: DXO2010DrawChartDraw.NonVisualInkContentPartProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIsComment(openXmlElement, value?.IsComment);
      SetContentPartLocks(openXmlElement, value?.ContentPartLocks);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
