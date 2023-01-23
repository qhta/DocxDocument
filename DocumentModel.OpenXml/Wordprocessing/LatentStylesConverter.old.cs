namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Latent Style Information.
/// </summary>
public static class LatentStylesConverter
{
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  private static Boolean? GetDefaultLockedState(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
  {
    return openXmlElement?.DefaultLockedState?.Value;
  }
  
  private static void SetDefaultLockedState(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DefaultLockedState = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DefaultLockedState = null;
  }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  private static Int32? GetDefaultUiPriority(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
  {
    return openXmlElement.DefaultUiPriority?.Value;
  }
  
  private static void SetDefaultUiPriority(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, Int32? value)
  {
    openXmlElement.DefaultUiPriority = value;
  }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  private static Boolean? GetDefaultSemiHidden(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
  {
    return openXmlElement?.DefaultSemiHidden?.Value;
  }
  
  private static void SetDefaultSemiHidden(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DefaultSemiHidden = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DefaultSemiHidden = null;
  }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  private static Boolean? GetDefaultUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
  {
    return openXmlElement?.DefaultUnhideWhenUsed?.Value;
  }
  
  private static void SetDefaultUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DefaultUnhideWhenUsed = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DefaultUnhideWhenUsed = null;
  }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  private static Boolean? GetDefaultPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
  {
    return openXmlElement?.DefaultPrimaryStyle?.Value;
  }
  
  private static void SetDefaultPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DefaultPrimaryStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DefaultPrimaryStyle = null;
  }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  private static Int32? GetCount(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
  {
    return openXmlElement.Count?.Value;
  }
  
  private static void SetCount(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, Int32? value)
  {
    openXmlElement.Count = value;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo> GetLatentStyleExceptionInfos(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement)
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
  
  private static void SetLatentStyleExceptionInfos(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>? value)
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
      value.TotalCount = GetCount(openXmlElement);
      value.Items = GetLatentStyleExceptionInfos(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LatentStyles? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LatentStyles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDefaultLockedState(openXmlElement, value?.DefaultLockedState);
      SetDefaultUiPriority(openXmlElement, value?.DefaultUiPriority);
      SetDefaultSemiHidden(openXmlElement, value?.DefaultSemiHidden);
      SetDefaultUnhideWhenUsed(openXmlElement, value?.DefaultUnhideWhenUsed);
      SetDefaultPrimaryStyle(openXmlElement, value?.DefaultPrimaryStyle);
      SetCount(openXmlElement, value?.TotalCount);
      SetLatentStyleExceptionInfos(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
