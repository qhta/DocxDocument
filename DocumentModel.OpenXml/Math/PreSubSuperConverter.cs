using DocumentModel.Math;
using PreSubSuper = DocumentFormat.OpenXml.Math.PreSubSuper;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Pre-Sub-Superscript Function.
/// </summary>
public static class PreSubSuperConverter
{
  /// <summary>
  ///   Pre-Sub-Superscript Properties.
  /// </summary>
  public static PreSubSuperProperties? GetPreSubSuperProperties(PreSubSuper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
    if (itemElement != null)
      return PreSubSuperPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPreSubSuperProperties(PreSubSuper? openXmlElement, PreSubSuperProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreSubSuperPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PreSubSuperProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Subscript (Pre-Sub-Superscript).
  /// </summary>
  public static SubArgument? GetSubArgument(PreSubSuper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubArgument(PreSubSuper? openXmlElement, SubArgument? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubArgumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubArgument>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public static SuperArgument? GetSuperArgument(PreSubSuper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperArgument(PreSubSuper? openXmlElement, SuperArgument? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperArgumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SuperArgument>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(PreSubSuper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(PreSubSuper? openXmlElement, Base? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.PreSubSuper? CreateModelElement(PreSubSuper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.PreSubSuper();
      value.PreSubSuperProperties = GetPreSubSuperProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.PreSubSuper? value)
    where OpenXmlElementType : PreSubSuper, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreSubSuperProperties(openXmlElement, value?.PreSubSuperProperties);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}