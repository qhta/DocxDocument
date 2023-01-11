namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Latent Style Information.
/// </summary>
public static class LatentStylesConverter
{
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  public static Boolean? GetDefaultLockedState(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultLockedState?.Value;
  }
  
  public static void SetDefaultLockedState(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultLockedState = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultLockedState = null;
  }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  public static Int32? GetDefaultUiPriority(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultUiPriority?.Value;
  }
  
  public static void SetDefaultUiPriority(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DefaultUiPriority = value;
  }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  public static Boolean? GetDefaultSemiHidden(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultSemiHidden?.Value;
  }
  
  public static void SetDefaultSemiHidden(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultSemiHidden = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultSemiHidden = null;
  }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  public static Boolean? GetDefaultUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultUnhideWhenUsed?.Value;
  }
  
  public static void SetDefaultUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultUnhideWhenUsed = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultUnhideWhenUsed = null;
  }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  public static Boolean? GetDefaultPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultPrimaryStyle?.Value;
  }
  
  public static void SetDefaultPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultPrimaryStyle = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultPrimaryStyle = null;
  }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  public static Int32? GetCount(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    return openXmlElement?.Count?.Value;
  }
  
  public static void SetCount(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Count = value;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>? GetLatentStyleExceptionInfos(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.LatentStyleExceptionInfoConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetLatentStyleExceptionInfos(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.LatentStyleExceptionInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.LatentStyles? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.LatentStyles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LatentStyles();
      value.DefaultLockedState = GetDefaultLockedState(openXmlElement);
      value.DefaultUiPriority = GetDefaultUiPriority(openXmlElement);
      value.DefaultSemiHidden = GetDefaultSemiHidden(openXmlElement);
      value.DefaultUnhideWhenUsed = GetDefaultUnhideWhenUsed(openXmlElement);
      value.DefaultPrimaryStyle = GetDefaultPrimaryStyle(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.LatentStyleExceptionInfos = GetLatentStyleExceptionInfos(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LatentStyles? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LatentStyles, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
