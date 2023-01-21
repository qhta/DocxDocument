namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  private static Boolean? GetApplyToFront(DXDrawCharts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToFront>();
    return itemElement != null;
  }
  
  private static void SetApplyToFront(DXDrawCharts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToFront>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ApplyToFront();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  private static Boolean? GetApplyToSides(DXDrawCharts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToSides>();
    return itemElement != null;
  }
  
  private static void SetApplyToSides(DXDrawCharts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToSides>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ApplyToSides();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  private static Boolean? GetApplyToEnd(DXDrawCharts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToEnd>();
    return itemElement != null;
  }
  
  private static void SetApplyToEnd(DXDrawCharts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ApplyToEnd>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ApplyToEnd();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  private static DMDrawsCharts.PictureFormatKind? GetPictureFormat(DXDrawCharts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureFormat>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDrawsCharts.PictureFormatKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPictureFormat(DXDrawCharts.PictureOptions openXmlElement, DMDrawsCharts.PictureFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.PictureFormat, DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DMDrawsCharts.PictureFormatKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  private static Double? GetPictureStackUnit(DXDrawCharts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PictureStackUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPictureStackUnit(DXDrawCharts.PictureOptions openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PictureStackUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PictureStackUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.PictureOptions? CreateModelElement(DXDrawCharts.PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PictureOptions();
      value.ApplyToFront = GetApplyToFront(openXmlElement);
      value.ApplyToSides = GetApplyToSides(openXmlElement);
      value.ApplyToEnd = GetApplyToEnd(openXmlElement);
      value.PictureFormat = GetPictureFormat(openXmlElement);
      value.PictureStackUnit = GetPictureStackUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PictureOptions? value)
    where OpenXmlElementType: DXDrawCharts.PictureOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetApplyToFront(openXmlElement, value?.ApplyToFront);
      SetApplyToSides(openXmlElement, value?.ApplyToSides);
      SetApplyToEnd(openXmlElement, value?.ApplyToEnd);
      SetPictureFormat(openXmlElement, value?.PictureFormat);
      SetPictureStackUnit(openXmlElement, value?.PictureStackUnit);
      return openXmlElement;
    }
    return default;
  }
}
