using DocumentFormat.OpenXml.Drawing;
using AdjustPoint2DType = DocumentModel.Drawings.AdjustPoint2DType;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Shape Connection Site.
/// </summary>
public static class ConnectionSiteConverter
{
  /// <summary>
  ///   Connection Site Angle
  /// </summary>
  public static String? GetAngle(ConnectionSite? openXmlElement)
  {
    return openXmlElement?.Angle?.Value;
  }

  public static void SetAngle(ConnectionSite? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Angle = new StringValue { Value = value };
      else
        openXmlElement.Angle = null;
  }

  /// <summary>
  ///   Position.
  /// </summary>
  public static AdjustPoint2DType? GetPosition(ConnectionSite? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Position>();
    if (itemElement != null)
      return AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPosition(ConnectionSite? openXmlElement, AdjustPoint2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustPoint2DTypeConverter.CreateOpenXmlElement<Position>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ConnectionSite? CreateModelElement(ConnectionSite? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionSite();
      value.Angle = GetAngle(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectionSite? value)
    where OpenXmlElementType : ConnectionSite, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAngle(openXmlElement, value?.Angle);
      SetPosition(openXmlElement, value?.Position);
      return openXmlElement;
    }
    return default;
  }
}