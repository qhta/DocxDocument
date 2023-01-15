using DocumentModel.Math;
using SubSuperscript = DocumentFormat.OpenXml.Math.SubSuperscript;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Sub-Superscript Function.
/// </summary>
public static class SubSuperscriptConverter
{
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  public static SubSuperscriptProperties? GetSubSuperscriptProperties(SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
    if (itemElement != null)
      return SubSuperscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubSuperscriptProperties(SubSuperscript? openXmlElement, SubSuperscriptProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubSuperscriptPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(SubSuperscript? openXmlElement, Base? value)
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

  /// <summary>
  ///   Subscript (Sub-Superscript).
  /// </summary>
  public static SubArgument? GetSubArgument(SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubArgument(SubSuperscript? openXmlElement, SubArgument? value)
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
  ///   Superscript (Sub-Superscript function).
  /// </summary>
  public static SuperArgument? GetSuperArgument(SubSuperscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperArgument(SubSuperscript? openXmlElement, SuperArgument? value)
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

  public static DocumentModel.Math.SubSuperscript? CreateModelElement(SubSuperscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.SubSuperscript();
      value.SubSuperscriptProperties = GetSubSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.SubSuperscript? value)
    where OpenXmlElementType : SubSuperscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSubSuperscriptProperties(openXmlElement, value?.SubSuperscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      return openXmlElement;
    }
    return default;
  }
}