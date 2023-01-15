using DocumentFormat.OpenXml.Office2019.Drawing.Diagram11;
using DiagramAutoBullet = DocumentModel.Drawings.Diagram1.DiagramAutoBullet;
using STorageType = DocumentModel.Drawings.Diagram1.STorageType;

namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
public static class NumberDiagramInfoConverter
{
  /// <summary>
  ///   lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public static UInt32? GetLvl(NumberDiagramInfo? openXmlElement)
  {
    return openXmlElement?.Lvl?.Value;
  }

  public static void SetLvl(NumberDiagramInfo? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Lvl = value;
  }

  /// <summary>
  ///   ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public static STorageType? GetPtType(NumberDiagramInfo? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, STorageType>(openXmlElement?.PtType?.Value);
  }

  public static void SetPtType(NumberDiagramInfo? openXmlElement, STorageType? value)
  {
    if (openXmlElement != null)
      openXmlElement.PtType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, STorageType>(value);
  }

  /// <summary>
  ///   DiagramAutoBullet.
  /// </summary>
  public static DiagramAutoBullet? GetDiagramAutoBullet(NumberDiagramInfo? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
    if (itemElement != null)
      return DiagramAutoBulletConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiagramAutoBullet(NumberDiagramInfo? openXmlElement, DiagramAutoBullet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramAutoBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagram1.NumberDiagramInfo? CreateModelElement(NumberDiagramInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram1.NumberDiagramInfo();
      value.Lvl = GetLvl(openXmlElement);
      value.PtType = GetPtType(openXmlElement);
      value.DiagramAutoBullet = GetDiagramAutoBullet(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagram1.NumberDiagramInfo? value)
    where OpenXmlElementType : NumberDiagramInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLvl(openXmlElement, value?.Lvl);
      SetPtType(openXmlElement, value?.PtType);
      SetDiagramAutoBullet(openXmlElement, value?.DiagramAutoBullet);
      return openXmlElement;
    }
    return default;
  }
}