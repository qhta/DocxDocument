using DocumentModel.Math;
using Nary = DocumentFormat.OpenXml.Math.Nary;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   n-ary Operator Function.
/// </summary>
public static class NaryConverter
{
  /// <summary>
  ///   n-ary Properties.
  /// </summary>
  public static NaryProperties? GetNaryProperties(Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.NaryProperties>();
    if (itemElement != null)
      return NaryPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNaryProperties(Nary? openXmlElement, NaryProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NaryProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NaryPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.NaryProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Lower limit (n-ary) .
  /// </summary>
  public static SubArgument? GetSubArgument(Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SubArgument>();
    if (itemElement != null)
      return SubArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubArgument(Nary? openXmlElement, SubArgument? value)
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
  ///   Upper limit (n-ary).
  /// </summary>
  public static SuperArgument? GetSuperArgument(Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperArgument(Nary? openXmlElement, SuperArgument? value)
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
  ///   Base (Argument).
  /// </summary>
  public static Base? GetBase(Nary? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(Nary? openXmlElement, Base? value)
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

  public static DocumentModel.Math.Nary? CreateModelElement(Nary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Nary();
      value.NaryProperties = GetNaryProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Nary? value)
    where OpenXmlElementType : Nary, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNaryProperties(openXmlElement, value?.NaryProperties);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}