using DocumentFormat.OpenXml.Wordprocessing;
using LatentStyleExceptionInfo = DocumentModel.Wordprocessing.LatentStyleExceptionInfo;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Latent Style Information.
/// </summary>
public static class LatentStylesConverter
{
  /// <summary>
  ///   Default Style Locking Setting
  /// </summary>
  public static Boolean? GetDefaultLockedState(LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultLockedState?.Value;
  }

  public static void SetDefaultLockedState(LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultLockedState = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultLockedState = null;
  }

  /// <summary>
  ///   Default User Interface Priority Setting
  /// </summary>
  public static Int32? GetDefaultUiPriority(LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultUiPriority?.Value;
  }

  public static void SetDefaultUiPriority(LatentStyles? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DefaultUiPriority = value;
  }

  /// <summary>
  ///   Default Semi-Hidden Setting
  /// </summary>
  public static Boolean? GetDefaultSemiHidden(LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultSemiHidden?.Value;
  }

  public static void SetDefaultSemiHidden(LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultSemiHidden = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultSemiHidden = null;
  }

  /// <summary>
  ///   Default Hidden Until Used Setting
  /// </summary>
  public static Boolean? GetDefaultUnhideWhenUsed(LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultUnhideWhenUsed?.Value;
  }

  public static void SetDefaultUnhideWhenUsed(LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultUnhideWhenUsed = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultUnhideWhenUsed = null;
  }

  /// <summary>
  ///   Default Primary Style Setting
  /// </summary>
  public static Boolean? GetDefaultPrimaryStyle(LatentStyles? openXmlElement)
  {
    return openXmlElement?.DefaultPrimaryStyle?.Value;
  }

  public static void SetDefaultPrimaryStyle(LatentStyles? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultPrimaryStyle = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DefaultPrimaryStyle = null;
  }

  /// <summary>
  ///   Latent Style Count
  /// </summary>
  public static Int32? GetCount(LatentStyles? openXmlElement)
  {
    return openXmlElement?.Count?.Value;
  }

  public static void SetCount(LatentStyles? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Count = value;
  }

  public static Collection<LatentStyleExceptionInfo>? GetLatentStyleExceptionInfos(LatentStyles? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LatentStyleExceptionInfo>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>())
      {
        var newItem = LatentStyleExceptionInfoConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLatentStyleExceptionInfos(LatentStyles? openXmlElement, Collection<LatentStyleExceptionInfo>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LatentStyleExceptionInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.LatentStyles? CreateModelElement(LatentStyles? openXmlElement)
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
    where OpenXmlElementType : LatentStyles, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDefaultLockedState(openXmlElement, value?.DefaultLockedState);
      SetDefaultUiPriority(openXmlElement, value?.DefaultUiPriority);
      SetDefaultSemiHidden(openXmlElement, value?.DefaultSemiHidden);
      SetDefaultUnhideWhenUsed(openXmlElement, value?.DefaultUnhideWhenUsed);
      SetDefaultPrimaryStyle(openXmlElement, value?.DefaultPrimaryStyle);
      SetCount(openXmlElement, value?.Count);
      SetLatentStyleExceptionInfos(openXmlElement, value?.LatentStyleExceptionInfos);
      return openXmlElement;
    }
    return default;
  }
}