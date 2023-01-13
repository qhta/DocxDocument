namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Backstage Class.
/// </summary>
public static class BackstageConverter
{
  /// <summary>
  /// onShow, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnShow(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement)
  {
    return openXmlElement?.OnShow?.Value;
  }
  
  public static void SetOnShow(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnShow = new StringValue { Value = value };
      else
        openXmlElement.OnShow = null;
  }
  
  /// <summary>
  /// onHide, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnHide(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement)
  {
    return openXmlElement?.OnHide?.Value;
  }
  
  public static void SetOnHide(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnHide = new StringValue { Value = value };
      else
        openXmlElement.OnHide = null;
  }
  
  public static DocumentModel.BackstageTab? GetBackstageTab(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageTabConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageTab(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement, DocumentModel.BackstageTab? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstageTabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.BackstageFastCommandButton? GetBackstageFastCommandButton(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageFastCommandButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageFastCommandButton(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement, DocumentModel.BackstageFastCommandButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstageFastCommandButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Backstage? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Backstage();
      value.OnShow = GetOnShow(openXmlElement);
      value.OnHide = GetOnHide(openXmlElement);
      value.BackstageTab = GetBackstageTab(openXmlElement);
      value.BackstageFastCommandButton = GetBackstageFastCommandButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Backstage? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.Backstage, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnShow(openXmlElement, value?.OnShow);
      SetOnHide(openXmlElement, value?.OnHide);
      SetBackstageTab(openXmlElement, value?.BackstageTab);
      SetBackstageFastCommandButton(openXmlElement, value?.BackstageFastCommandButton);
      return openXmlElement;
    }
    return default;
  }
}
