namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Latent Style Exception.
/// </summary>
public static class LatentStyleExceptionInfoConverter
{
  /// <summary>
  /// Primary Style Name
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  private static Boolean? GetLocked(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static void SetLocked(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  private static Int32? GetUiPriority(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement.UiPriority?.Value;
  }
  
  private static void SetUiPriority(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement, Int32? value)
  {
    openXmlElement.UiPriority = value;
  }
  
  /// <summary>
  /// Semi hidden text override
  /// </summary>
  private static Boolean? GetSemiHidden(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.SemiHidden?.Value;
  }
  
  private static void SetSemiHidden(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SemiHidden = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.SemiHidden = null;
  }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  private static Boolean? GetUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.UnhideWhenUsed?.Value;
  }
  
  private static void SetUnhideWhenUsed(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UnhideWhenUsed = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.UnhideWhenUsed = null;
  }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  private static Boolean? GetPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.PrimaryStyle?.Value;
  }
  
  private static void SetPrimaryStyle(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PrimaryStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.PrimaryStyle = null;
  }
  
  public static DocumentModel.Wordprocessing.LatentStyleExceptionInfo? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.LatentStyleExceptionInfo();
      value.Name = GetName(openXmlElement);
      value.Locked = GetLocked(openXmlElement);
      value.UiPriority = GetUiPriority(openXmlElement);
      value.SemiHidden = GetSemiHidden(openXmlElement);
      value.UnhideWhenUsed = GetUnhideWhenUsed(openXmlElement);
      value.PrimaryStyle = GetPrimaryStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.LatentStyleExceptionInfo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetLocked(openXmlElement, value?.Locked);
      SetUiPriority(openXmlElement, value?.UiPriority);
      SetSemiHidden(openXmlElement, value?.SemiHidden);
      SetUnhideWhenUsed(openXmlElement, value?.UnhideWhenUsed);
      SetPrimaryStyle(openXmlElement, value?.PrimaryStyle);
      return openXmlElement;
    }
    return default;
  }
}
