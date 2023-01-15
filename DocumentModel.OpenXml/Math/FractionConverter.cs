using DocumentModel.Math;
using Fraction = DocumentFormat.OpenXml.Math.Fraction;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Fraction Function.
/// </summary>
public static class FractionConverter
{
  /// <summary>
  ///   Fraction Properties.
  /// </summary>
  public static FractionProperties? GetFractionProperties(Fraction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.FractionProperties>();
    if (itemElement != null)
      return FractionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFractionProperties(Fraction? openXmlElement, FractionProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FractionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FractionProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Numerator.
  /// </summary>
  public static Numerator? GetNumerator(Fraction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Numerator>();
    if (itemElement != null)
      return NumeratorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumerator(Fraction? openXmlElement, Numerator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Numerator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumeratorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Numerator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Denominator.
  /// </summary>
  public static Denominator? GetDenominator(Fraction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Denominator>();
    if (itemElement != null)
      return DenominatorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDenominator(Fraction? openXmlElement, Denominator? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Denominator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DenominatorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Denominator>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.Fraction? CreateModelElement(Fraction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Fraction();
      value.FractionProperties = GetFractionProperties(openXmlElement);
      value.Numerator = GetNumerator(openXmlElement);
      value.Denominator = GetDenominator(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Fraction? value)
    where OpenXmlElementType : Fraction, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFractionProperties(openXmlElement, value?.FractionProperties);
      SetNumerator(openXmlElement, value?.Numerator);
      SetDenominator(openXmlElement, value?.Denominator);
      return openXmlElement;
    }
    return default;
  }
}