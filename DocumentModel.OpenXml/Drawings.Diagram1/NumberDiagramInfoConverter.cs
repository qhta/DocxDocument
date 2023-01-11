namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfo Class.
/// </summary>
public static class NumberDiagramInfoConverter
{
  /// <summary>
  /// lvl, this property is only available in Office 2019 and later.
  /// </summary>
  public static UInt32? GetLvl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
  {
    return openXmlElement?.Lvl?.Value;
  }
  
  public static void SetLvl(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Lvl = value;
  }
  
  /// <summary>
  /// ptType, this property is only available in Office 2019 and later.
  /// </summary>
  public static DocumentModel.Drawings.Diagram1.STorageType? GetPtType(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DocumentModel.Drawings.Diagram1.STorageType>(openXmlElement?.PtType?.Value);
  }
  
  public static void SetPtType(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement, DocumentModel.Drawings.Diagram1.STorageType? value)
  {
    if (openXmlElement != null)
      openXmlElement.PtType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType, DocumentModel.Drawings.Diagram1.STorageType>(value);
  }
  
  /// <summary>
  /// DiagramAutoBullet.
  /// </summary>
  public static DocumentModel.Drawings.Diagram1.DiagramAutoBullet? GetDiagramAutoBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagram1.DiagramAutoBulletConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDiagramAutoBullet(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement, DocumentModel.Drawings.Diagram1.DiagramAutoBullet? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagram1.DiagramAutoBulletConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagram1.NumberDiagramInfo? CreateModelElement(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
