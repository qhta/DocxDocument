using DocumentModel.Drawings.ChartDrawings;
using Legend = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Legend;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Legend Class.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  ///   pos, this property is only available in Office 2016 and later.
  /// </summary>
  public static SidePos? GetPos(Legend? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, SidePos>(openXmlElement?.Pos?.Value);
  }

  public static void SetPos(Legend? openXmlElement, SidePos? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, SidePos>(value);
  }

  /// <summary>
  ///   align, this property is only available in Office 2016 and later.
  /// </summary>
  public static PosAlign? GetAlign(Legend? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, PosAlign>(openXmlElement?.Align?.Value);
  }

  public static void SetAlign(Legend? openXmlElement, PosAlign? value)
  {
    if (openXmlElement != null)
      openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, PosAlign>(value);
  }

  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetOverlay(Legend? openXmlElement)
  {
    return openXmlElement?.Overlay?.Value;
  }

  public static void SetOverlay(Legend? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Overlay = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Overlay = null;
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Legend? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public static TxPrTextBody? GetTxPrTextBody(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTxPrTextBody(Legend? openXmlElement, TxPrTextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TxPrTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(Legend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Legend? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.Legend? CreateModelElement(Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Legend();
      value.Pos = GetPos(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Legend? value)
    where OpenXmlElementType : Legend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPos(openXmlElement, value?.Pos);
      SetAlign(openXmlElement, value?.Align);
      SetOverlay(openXmlElement, value?.Overlay);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}