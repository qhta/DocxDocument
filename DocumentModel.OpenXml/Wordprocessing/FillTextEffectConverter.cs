namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
public static class FillTextEffectConverter
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  private static Boolean? GetNoFillEmpty(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
    return itemElement != null;
  }
  
  private static void SetNoFillEmpty(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  private static DocumentModel.Wordprocessing.SolidColorFillProperties? GetSolidColorFillProperties(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidColorFillProperties(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement, DocumentModel.Wordprocessing.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  private static DocumentModel.Wordprocessing.GradientFillProperties? GetGradientFillProperties(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.GradientFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFillProperties(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect openXmlElement, DocumentModel.Wordprocessing.GradientFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.GradientFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.FillTextEffect? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.FillTextEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FillTextEffect();
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FillTextEffect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.FillTextEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
      SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
      SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
      return openXmlElement;
    }
    return default;
  }
}
