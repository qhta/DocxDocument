using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using EffectReference = DocumentModel.Drawings.ChartsStyle.EffectReference;
using FillReference = DocumentModel.Drawings.ChartsStyle.FillReference;
using FontReference = DocumentModel.Drawings.ChartsStyle.FontReference;
using LeaderLine = DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine;
using LineReference = DocumentModel.Drawings.ChartsStyle.LineReference;
using ShapeProperties = DocumentModel.Drawings.ChartsStyle.ShapeProperties;
using TextBodyProperties = DocumentModel.Drawings.ChartsStyle.TextBodyProperties;
using TextCharacterPropertiesType = DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the LeaderLine Class.
/// </summary>
public static class LeaderLineConverter
{
  public static LineReference? GetLineReference(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
    if (itemElement != null)
      return LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineReference(LeaderLine? openXmlElement, LineReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetLineWidthScale(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LineWidthScale>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetLineWidthScale(LeaderLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineWidthScale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LineWidthScale { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FillReference? GetFillReference(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
    if (itemElement != null)
      return FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillReference(LeaderLine? openXmlElement, FillReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EffectReference? GetEffectReference(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
    if (itemElement != null)
      return EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectReference(LeaderLine? openXmlElement, EffectReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FontReference? GetFontReference(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
    if (itemElement != null)
      return FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFontReference(LeaderLine? openXmlElement, FontReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties? GetShapeProperties(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(LeaderLine? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextCharacterPropertiesType? GetTextCharacterPropertiesType(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
    if (itemElement != null)
      return TextCharacterPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextCharacterPropertiesType(LeaderLine? openXmlElement, TextCharacterPropertiesType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextCharacterPropertiesTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextBodyProperties? GetTextBodyProperties(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
    if (itemElement != null)
      return TextBodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBodyProperties(LeaderLine? openXmlElement, TextBodyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBodyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartsStyle.LeaderLine? CreateModelElement(LeaderLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.LeaderLine();
      value.LineReference = GetLineReference(openXmlElement);
      value.LineWidthScale = GetLineWidthScale(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextCharacterPropertiesType = GetTextCharacterPropertiesType(openXmlElement);
      value.TextBodyProperties = GetTextBodyProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.LeaderLine? value)
    where OpenXmlElementType : LeaderLine, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineReference(openXmlElement, value?.LineReference);
      SetLineWidthScale(openXmlElement, value?.LineWidthScale);
      SetFillReference(openXmlElement, value?.FillReference);
      SetEffectReference(openXmlElement, value?.EffectReference);
      SetFontReference(openXmlElement, value?.FontReference);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextCharacterPropertiesType(openXmlElement, value?.TextCharacterPropertiesType);
      SetTextBodyProperties(openXmlElement, value?.TextBodyProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}