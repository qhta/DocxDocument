using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Dash Stop.
/// </summary>
public static class DashStopConverter
{
  /// <summary>
  ///   Dash Length
  /// </summary>
  public static Int32? GetDashLength(DashStop? openXmlElement)
  {
    return openXmlElement?.DashLength?.Value;
  }

  public static void SetDashLength(DashStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DashLength = value;
  }

  /// <summary>
  ///   Space Length
  /// </summary>
  public static Int32? GetSpaceLength(DashStop? openXmlElement)
  {
    return openXmlElement?.SpaceLength?.Value;
  }

  public static void SetSpaceLength(DashStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SpaceLength = value;
  }

  public static DocumentModel.Drawings.DashStop? CreateModelElement(DashStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.DashStop();
      value.DashLength = GetDashLength(openXmlElement);
      value.SpaceLength = GetSpaceLength(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.DashStop? value)
    where OpenXmlElementType : DashStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDashLength(openXmlElement, value?.DashLength);
      SetSpaceLength(openXmlElement, value?.SpaceLength);
      return openXmlElement;
    }
    return default;
  }
}